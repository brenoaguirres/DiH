namespace CBPXL.ControllableCharacter.ControllableCharacterStateMachine
{
    public class ControllableCharacterStateFactory
    {
        #region REFERENCES

        private ControllableCharacterStateMachine _context;

        #endregion

        #region CONSTRUCTOR

        public ControllableCharacterStateFactory(ControllableCharacterStateMachine currentContext)
        {
            _context = currentContext;
        }

        #endregion

        #region STATES

        public ControllableCharacterState Idle()
        {
            return new ControllableCharacterStateIdle(_context, this);
        }

        public ControllableCharacterState Walk()
        {
            return new ControllableCharacterStateWalk(_context, this);
        }

        public ControllableCharacterState Run()
        {
            return new ControllableCharacterStateRun(_context, this);
        }

        public ControllableCharacterState Jump()
        {
            return new ControllableCharacterStateJump(_context, this);
        }

        public ControllableCharacterState Ground()
        {
            return new ControllableCharacterStateGround(_context, this);
        }

        public ControllableCharacterState Fall()
        {
            return new ControllableCharacterStateFall(_context, this);
        }
        
        public ControllableCharacterState Aim()
        {
            return new ControllableCharacterStateAim(_context, this);
        }

        #endregion
    }
}
