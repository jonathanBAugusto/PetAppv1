using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
using DevExpress.XtraEditors;

namespace WindowsFormsApp1
{
    class Funcoes
    {

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

        public static void Aviso (string aviso)
        {
            MessageBox.Show(aviso);
        }

        public static void LocalizarCEP(string CEP, TextEdit edEstado, TextEdit edCidade, TextEdit edBairro, TextEdit edRua)
        {
            try
            {
                var ws = new WSCorreios.AtendeClienteClient();
                var resposta = ws.consultaCEP(Funcoes.toString(CEP));
                edCidade.EditValue = resposta.cidade;
                edRua.EditValue = resposta.end;
                edBairro.EditValue = resposta.bairro;
                edEstado.EditValue = resposta.uf;
            }
            catch (Exception ex)
            {
                Aviso(Funcoes.toString(ex.Message));
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
