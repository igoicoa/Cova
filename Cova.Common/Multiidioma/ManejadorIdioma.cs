using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cova.BE.Multiidioma;
using Cova.MPP;

namespace Cova.Servicios.Multiidioma
{
    public class ManejadorIdioma
    {
        public Idioma Idioma { get; set; }
        private IList<IIdiomaObserver> _idiomaObservers;

        public ManejadorIdioma(Idioma idioma)
        {
            this.Idioma = idioma;
            this._idiomaObservers = new List<IIdiomaObserver>();
        }

        public void SuscribirObservador(IIdiomaObserver observador)
        {
            this._idiomaObservers.Add(observador);
        }
        public void DesuscribirObservador(IIdiomaObserver observador)
        {
            this._idiomaObservers.Remove(observador);
        }

        private void Notificar(Idioma idioma)
        {
            foreach (IIdiomaObserver observer in this._idiomaObservers)
            {
                observer.UpdateLanguage(idioma);
            }
        }

        public void CambiarIdioma(Idioma idiomaElegido)
        {
            this.Idioma = idiomaElegido;
            this.Notificar(idiomaElegido);
        }

        public bool CrearIdioma(Idioma idiomaNuevo)
        {
            MPPTraductor mPPTraductor = new MPPTraductor();
            return mPPTraductor.CrearIdioma(idiomaNuevo);
        }

        public bool AgregarTraducciones(IList<Traduccion> nuevaTraduccion)
        {
            MPPTraductor mPPTraductor = new MPPTraductor();
            return mPPTraductor.AgregarTraducciones(nuevaTraduccion);
        }

        public IDictionary<string, Traduccion> ObtenerEtiquetasIdiomaDefault()
        {
            MPPTraductor mPPTraductor = new MPPTraductor();
            return mPPTraductor.ObtenerEtiquetasIdiomaDefault();
        }

        public IList<Idioma> ObtenerIdiomas()
        {
            MPPTraductor mPPTraductor = new MPPTraductor();
            return mPPTraductor.ObtenerIdiomas();
        }

    }
}
