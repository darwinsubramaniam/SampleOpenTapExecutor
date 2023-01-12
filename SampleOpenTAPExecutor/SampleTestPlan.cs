using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTap;

namespace SampleOpenTAPExecutor
{
    public class SampleTestPlanBuilder
    {
        public static TestPlan GetTestPlan()
        {
            var logTestStep = new OpenTap.Plugins.BasicSteps.LogStep
            {
                LogMessage = "Hi Darwin"
            };

            var delayTestStep = new OpenTap.Plugins.BasicSteps.DelayStep
            {
                DelaySecs = 3
            };

            var testplan = new TestPlan();
            testplan.ChildTestSteps.Add(logTestStep);
            testplan.ChildTestSteps.Add(delayTestStep);

            return testplan;
        }
    }
}
