using System.Media;

namespace A21_Ex03_IdoAmira_207947250_SaarSkittel_308471473
{
    public class SoundListBox : ActionListBoxDecorator
    {
        public SoundListBox(IDecoratedListBox i_Decorated) : base(i_Decorated)
        {

        }

        public override void Operation()
        {
            this.m_Decorated.Operation();
            this.Sound();
        }

        public void Sound()
        {
            IDecoratedListBox actionListBox = this.m_Decorated;
            while (!(actionListBox is ActionListBoxProxy))
            {
                actionListBox = (actionListBox as ActionListBoxDecorator).Decorated;
            }

            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();
        }
    }
}
