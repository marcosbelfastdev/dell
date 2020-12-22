using System;
 
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace dell.tests.steps
{
    [Binding]
    public class Step
    {

        [Given(@"I am logged")]
        public void test() {
            Console.WriteLine("Step run from feature file");
        }
    }
}