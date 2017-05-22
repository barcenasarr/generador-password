using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etapa_4
{
    public class Password
    {
        private int longitud;
        private string contrasena;
        private bool fuerte;

        public int Longitud { get => longitud; set => longitud = value; }
        public string Contrasena { get => contrasena; set => contrasena = value; }
        public bool Fuerte { get => fuerte; set => fuerte = value; }

        public Password()
        {
            this.longitud = 8;
            this.contrasena = "qgFUaer738aAT716";
            this.fuerte = esFuerte(this.longitud, this.contrasena);
        }

        public Password(int longitud, Random rnd)
        {
            this.longitud = longitud;
            this.contrasena = generarPassword(this.longitud, rnd);
            this.fuerte = esFuerte(this.longitud, this.contrasena);
        }

        private string generarPassword(int longitud, Random rnd)
        {
            string caracteres = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            char[] chars = new char[longitud];
            object syncLock = new object();

            for (int i = 0; i < longitud; i++)
            {
                chars[i] = caracteres[rnd.Next(0, caracteres.Length)];
            }

            return new string(chars);
        }

        private bool esFuerte(int longitud, string contrasena)
        {
            int mayu = 0;
            int minu = 0;
            int num = 0;

            for (int i = 0; i < longitud; i++)
            {
                if (char.IsUpper(contrasena[i]))
                {
                    mayu++;
                }
                else
                {
                    if (char.IsLower(contrasena[i]))
                    {
                        minu++;
                    }
                    else
                    {
                        if (char.IsNumber(contrasena[i]))
                        {
                            num++;
                        }
                    }
                }
            }

            if (mayu > 2 && minu > 1 && num > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
