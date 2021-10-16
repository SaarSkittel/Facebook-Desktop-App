using System.Threading;

namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public class BlinkingListBox : ActionListBoxDecorator
    {
        public BlinkingListBox(IDecoratedListBox i_Decorated) : base(i_Decorated)
        {

        }

        public override void Operation()
        {
            this.m_Decorated.Operation();
            this.Blink();
        }

        public void Blink()
        {
            IDecoratedListBox Decorated = this.m_Decorated;
            while (!(Decorated is ActionListBoxProxy))
            {
                Decorated = (Decorated as ActionListBoxDecorator).Decorated;
            }

            this.changeBackgoundColor(Decorated as ActionListBoxProxy);

        }

        private void changeBackgoundColor(ActionListBoxProxy i_Decorated)
        {
            System.Drawing.Color ListbBoxColor = i_Decorated.BackColor;
            for (int i = 0; i < 10; ++i)
            {
                if (i_Decorated.BackColor == ListbBoxColor)
                {
                    i_Decorated.BackColor = System.Drawing.Color.Lime;
                }
                else
                {
                    i_Decorated.BackColor = ListbBoxColor;
                }

                Thread.Sleep(250);
            }
        }
    }
}
