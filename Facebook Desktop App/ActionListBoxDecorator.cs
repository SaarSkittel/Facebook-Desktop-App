namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public class ActionListBoxDecorator : IDecoratedListBox
    {
        protected IDecoratedListBox m_Decorated;

        public IDecoratedListBox Decorated
        {
            get
            {
                return this.m_Decorated;
            }
        }

        public ActionListBoxDecorator(IDecoratedListBox i_Decorated)
        {
            this.m_Decorated = i_Decorated;
        }

        public virtual void Operation()
        {
            if (this.m_Decorated != null)
            {
                this.m_Decorated.Operation();
            }
        }
    }
}
