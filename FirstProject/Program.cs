using System;
using System.Collections.Generic;

namespace FirstProject
{

    public interface activity
    {
         void execute();
    }
    public class UploadVideo : activity
    {
        public void execute() {
            Console.WriteLine("video Uploaded");

        }
    }
    public class WorkFlow
    {
        private readonly List<activity> _activities;
        public WorkFlow()
        {
            _activities = new List<activity>();
            
        }
        public void Addactivity(activity activity)
        {
            _activities.Add(activity);
        }
        public IEnumerable<activity> Getactivities()
        {
            return _activities;
            
        }
         
    }

    public class WorkFlowEngine
    {
        public void Run(WorkFlow workFlow)
        {
            foreach(var act in workFlow.Getactivities())
            {
                act.execute();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkFlow();
            workflow.Addactivity( new UploadVideo());

            var workFlowEngine = new WorkFlowEngine();
            workFlowEngine.Run(workflow);

            Console.WriteLine("Executed");


        }

    }
}
    

