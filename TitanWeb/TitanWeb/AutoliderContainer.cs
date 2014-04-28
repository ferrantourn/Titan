using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TitanWeb
{
    public class AutoliderContainer
    {
        string sMarca;

        public string SMarca
        {
            get { return sMarca; }
            set { sMarca = value; }
        }

        string sModelo;

        public string SModelo
        {
            get { return sModelo; }
            set { sModelo = value; }
        }
        string sCilindrada;

        public string SCilindrada
        {
            get { return sCilindrada; }
            set { sCilindrada = value; }
        }
        string sMotor;

        public string SMotor
        {
            get { return sMotor; }
            set { sMotor = value; }
        }
        string sPrecio;

        public string SPrecio
        {
            get { return sPrecio; }
            set { sPrecio = value; }
        }
        string sDescripcionMultiLine;

        public string SDescripcionMultiLine
        {
            get { return sDescripcionMultiLine; }
            set { sDescripcionMultiLine = value; }
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
        Uri FondoPrecio;

        public Uri SFondoPrecio
        {
            get { return FondoPrecio; }
            set { FondoPrecio = value; }
        }
        Uri FondoPlantilla;

        public Uri SFondoPlantilla
        {
            get { return FondoPlantilla; }
            set { FondoPlantilla = value; }
        }
        Uri Logo;

        public Uri SLogo
        {
            get { return Logo; }
            set { Logo = value; }
        }

        public AutoliderContainer()
        {
 
        }
        public AutoliderContainer(string sMarca, string sModelo, string sCilindrada, string sMotor,
                                      string sPrecio, string sDescripcionMultiLine,
                                      Uri Foto1, Uri Foto2, Uri Foto3, Uri Foto4, Uri FondoPrecio,
                                      Uri FondoPlantilla,
                                      Uri Logo)
        {
            this.Foto1 = Foto1;
            this.Foto2 = Foto2;
            this.Foto3 = Foto3;
            this.Foto4 = Foto4;
            this.sMarca = sMarca;
            this.sModelo = sModelo;
            this.sMotor = sMotor;
            this.sPrecio = sPrecio;
            this.FondoPlantilla = FondoPlantilla;
            this.FondoPrecio = FondoPrecio;
            this.Logo = Logo;
            this.sDescripcionMultiLine = sDescripcionMultiLine;
            this.sCilindrada = sCilindrada;

        }

    }
}