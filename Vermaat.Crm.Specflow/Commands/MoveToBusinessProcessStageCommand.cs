﻿using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vermaat.Crm.Specflow.Commands
{
    class MoveToBusinessProcessStageCommand : ApiOnlyCommand
    {
        private readonly string _alias;
        private readonly string _stageName;

        public MoveToBusinessProcessStageCommand(CrmTestingContext crmContext, string alias, string stageName) : base(crmContext)
        {
            this._alias = alias;
            this._stageName = stageName;
        }

        public override void Execute()
        {
            EntityReference crmRecord = _crmContext.RecordCache[_alias];
            var instance = BusinessProcessFlowHelper.GetProcessInstanceOfRecord(_crmContext, crmRecord);
            var path = BusinessProcessFlowHelper.GetActivePath(_crmContext, instance);

            int currentStage = -1;
            int desiredStage = -1;

            for (int i = 0; i < path.Length && (currentStage == -1 || desiredStage == -1); i++)
            {
                if (_stageName == path[i].GetAttributeValue<string>("stagename"))
                    desiredStage = i;
                if (path[i].Id == instance.GetAttributeValue<Guid>("processstageid"))
                    currentStage = i;
            }

            if (currentStage == -1)
                throw new InvalidOperationException("Current stage can't be found");
            if (desiredStage == -1)
                throw new InvalidOperationException($"{_stageName} isn't in the active path");

            if (currentStage == desiredStage)
                return;

            var processRecord = BusinessProcessFlowHelper.GetProcessRecord(_crmContext, crmRecord, instance.Id);

            if (desiredStage < currentStage)
            {
                processRecord["activestageid"] = path[desiredStage].ToEntityReference();
                _crmContext.Service.Update(processRecord);
                return;
            }

            while (desiredStage > currentStage)
            {
                processRecord["activestageid"] = path[currentStage + 1].ToEntityReference();
                _crmContext.Service.Update(processRecord);
                currentStage++;
            }
        }
    }
}