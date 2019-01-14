using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
using DevExpress.XtraEditors;

namespace PetApp
{
    class F
    {
        public static string imgPath = "TEMPIMG";

        public static bool copyToImagePath(string imgPath, string nameImg = "")
        {
            if (nameImg == "")
            {
                nameImg = System.IO.Path.GetFileName(imgPath);
            }
            
            if (!System.IO.Directory.Exists(imgPath))
            {
                System.IO.Directory.CreateDirectory(imgPath);
            }

            try
            {
                System.IO.File.Copy(imgPath, System.IO.Path.Combine(imgPath, nameImg), true);
            }
            catch (Exception ex)
            {
                Aviso("Erro ao Salva/Alterar Imagem\n" + ex.Message);
                return false;
            }
            return true;
        }
        public static void WriteLOG(string log)
        {
            if (!File.Exists("LOG.txt"))
            {
                File.Create("LOG.txt");
            }

            StreamWriter sw = new StreamWriter("LOG.txt");
            sw.NewLine = log;
            sw.Close();
        }

        public static string toString(object Value, string Default = "")
        {
            string result = Default;
            if ((Value != DBNull.Value) || (Value != null))
            {
                try
                {
                    result = Convert.ToString(Value).Trim();
                }
                catch
                {
                    result = "";
                }
            }
            return result;
        }

        public static int toInt(object Value, int Default = 0)
        {
            try
            {
                if ((Value == DBNull.Value) || (Value == null) || (toString(Value) == ""))
                {
                    return Default;
                }
                return Convert.ToInt32(Value);
            }
            catch
            {
                return Default;
            }
        }

        public static double toDouble(object Value, double Default = 0.0)
        {
            try
            {
                if ((Value == DBNull.Value) || (Value == null) || (toString(Value) == ""))
                {
                    return Default;
                }
                return Convert.ToDouble(Value);
            }
            catch
            {
                return Default;
            }
        }

        public static void Aviso(string aviso)
        {
            MessageBox.Show(aviso);
        }

        public static void LocalizarCEP(string CEP, TextEdit edEstado, TextEdit edCidade, TextEdit edBairro, TextEdit edRua)
        {
            try
            {
                var ws = new WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(F.toString(CEP));
                edCidade.EditValue = resposta.cidade;
                edRua.EditValue = resposta.end;
                edBairro.EditValue = resposta.bairro;
                edEstado.EditValue = resposta.uf;
            }
            catch (Exception ex)
            {
                Aviso(F.toString(ex.Message));
                F.WriteLOG("----------------------\nLOG WSCorreios - " + DateTime.Now.ToString() + " - Erro: " + ex.Message);
            }
        }

        public static int idade(DateTime data)
        {
            int anoNow = DateTime.Now.Year;
            int anoNas = data.Year;
            int age = anoNow - anoNas;
            return age;
        }
    }
}
