﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //Banana-> _paisOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Banana'); 
    //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->false
   public class Banana: Fruta
    {
        protected string _paisOrigen;

        public string Nombre
        {
            get
            {
                return "banana";
            }
        }

        public override bool TieneCarojo
        {
            get
            {
                return false;
            }
        }

        public Banana()
        {

        }

        public Banana(string color , double peso , string provi): base(color,peso)
        {
            this._paisOrigen = provi;
        }


        protected override string FrutaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutaToString());
            sb.AppendFormat("Pais Origen: {0}", this._paisOrigen);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }
    }
}
