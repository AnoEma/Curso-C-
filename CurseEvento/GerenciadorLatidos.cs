using System;

namespace CurseEvento
{
    public class GerenciadorLatidos
    {
        private int _intensidadeLatidos;
        public event EventHandler  ExessoDecibeiEvent;

        public GerenciadorLatidos()
        {
            _intensidadeLatidos = 0;
        }

        public int Latir()
        {
            _intensidadeLatidos += 10;
            if(_intensidadeLatidos > 80)
            {
                ExcessoDecibeisEventArgs e = new ExcessoDecibeisEventArgs
                {
                    IntensidadeLatido = _intensidadeLatidos
                };
                OnExcessoDecibeis(e);
            }
            return _intensidadeLatidos;
        }
        protected virtual void OnExcessoDecibeis(EventArgs e)
        {
            if(ExessoDecibeiEvent != null)
            {
                ExessoDecibeiEvent(this, e);
            }
        }
    }
}