using ESAPIX.Constraints;
using Prism.Mvvm;
using VMS.TPS.Common.Model.API;

namespace PlanChecker_Su.ViewModels
{
    public class PlanConstraint : BindableBase
    {
        public PlanConstraint(IConstraint con)
        {
            this.Constraint = con;
        }


        private IConstraint _constraint;

        public IConstraint Constraint
        {
            get { return _constraint; }
            set { SetProperty(ref _constraint, value); }
        }

        private ConstraintResult _result;

        public ConstraintResult Result
        {
            get { return _result; }
            set { SetProperty(ref _result, value); }
        }
    /*: IConstraint /* implement a interface*/
    
    //    public string Name => throw new System.NotImplementedException();

    //    public string FullName => throw new System.NotImplementedException();

    //    public ConstraintResult CanConstrain(PlanningItem pi)
    //    {
    //        throw new System.NotImplementedException();
    //    }

    //    public ConstraintResult Constrain(PlanningItem pi)
    //    {
    //        throw new System.NotImplementedException();
    //    }
    }
}