using Microsoft.SqlServer.Dac.Deployment;
﻿using Microsoft.SqlServer.Dac.Extensibility;

namespace SampleDeploymentContributor
{
    [ExportDeploymentPlanModifier("SampleDeploymentContributor.SampleDeploymentContributor", "1.0")]
    public class SampleDeploymentContributor : DeploymentPlanModifier
    {
            /// <inheritdoc />
            protected override void OnExecute(DeploymentPlanContributorContext context)
            {
                    PublishMessage(new ExtensibilityError("Sample deployment contributor executed.", Severity.Message));
            }
    }
}
