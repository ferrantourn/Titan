using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TitanWeb
{
    [Serializable]
    public class LeblonContainer
    {

        string sTitulo;

        public string STitulo
        {
            get { return sTitulo; }
            set { sTitulo = value; }
        }

        string sCuadroMultiLine1;

        public string SCuadroMultiLine1
        {
            get { return sCuadroMultiLine1; }
            set { sCuadroMultiLine1 = value; }
        }

        string sCuadroMultiLine2;

        public string SCuadroMultiLine2
        {
            get { return sCuadroMultiLine2; }
            set { sCuadroMultiLine2 = value; }
        }


        string sDescripcionMultiLine;
        public string SDescripcionMultiLine
        {
            get { return sDescripcionMultiLine; }
            set { sDescripcionMultiLine = value; }
        }

        string sPrecio;
        public string SPrecio
        {
            get { return sPrecio; }
            set { sPrecio = value; }
        }

        Uri Foto1;

        public Uri SFoto1
        {
            get { return Foto1; }
            set { Foto1 = value; }
        }
        Uri Foto2;

        public Uri SFoto2
        {
            get { return Foto2; }
            set { Foto2 = value; }
        }
        Uri Foto3;

        public Uri SFoto3
        {
            get { return Foto3; }
            set { Foto3 = value; }
        }
        Uri Foto4;

        public Uri SFoto4
        {
            get { return Foto4; }
            set { Foto4 = value; }
        }

        Uri FondoPlantilla;

        public Uri SFondoPlantilla
        {
            get { return FondoPlantilla; }
            set { FondoPlantilla = value; }
        }

        public LeblonContainer()
        {
 
        }
        public LeblonContainer(string sTitulo, string sCuadroMultiLine1, string sCuadroMultiLine2, string sDescripcionMultiLine, string sPrecio, 
                                Uri Foto1, Uri Foto2, Uri Foto3, Uri Foto4, Uri FondoPlantilla)
        {
            this.Foto1 = Foto1;
            this.Foto2 = Foto2;
            this.Foto3 = Foto3;
            this.Foto4 = Foto4;
            this.sPrecio = sPrecio;
            this.FondoPlantilla = FondoPlantilla;
            this.sDescripcionMultiLine = sDescripcionMultiLine;
            this.sTitulo = sTitulo;
            this.sCuadroMultiLine1 = sCuadroMultiLine1;
            this.sCuadroMultiLine2 = sCuadroMultiLine2;
            
        }

    }
}