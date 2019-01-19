using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
using PetApp.Model;

namespace PetApp
{
    public partial class FrmCadCli : DevExpress.XtraEditors.XtraForm
    {
        List<Pets> pets = new List<Pets>();
        public FrmCadCli()
        {
            InitializeComponent();

            gridControlPet.DataSource = pets;

            List<Clientes> clientes = new List<Clientes>();
            clientes.Add(new Clientes {
                CLI_RAZAO = F.toString(edCLI_RAZAO.EditValue),
                CLI_FANTASIA = F.toString(edCLI_FANTASIA),
                CLI_INSCRICAO = F.toString(edCLI_INSCRICAO),
                CLI_CNPJ = F.toString(edCLI_CNPJ.EditValue),
                CLI_EMAIL = F.toString(edCLI_EMAIL.EditValue),
                CLI_TEL = F.toString(edCLI_TEL.EditValue),
                CLI_CEL = F.toString(edCLI_CEL.EditValue),
                CLI_NASC = F.toString(edCLI_NASC.EditValue),
                CLI_CEP = F.toString(edCEP.EditValue),
                CLI_BAIRRO = F.toString(edBairro.EditValue),
                CLI_NUMERO = F.toString(edNumero.EditValue),
                CLI_PESTIPO = F.toString(rgCLI_PESTIPO.EditValue),
                CLI_RUA = F.toString(edRua.EditValue),
            });

        }
        //
        private void FrmCadCli_Load(object sender, EventArgs e)
        {
            rgCLI_PESTIPO.EditValue = "FIS";
        }

        private void rgPesTipo_EditValueChanged(object sender, EventArgs e)
        {
            if (F.toString(rgCLI_PESTIPO.EditValue) == "JUR")
            {
                edCLI_NASC.Enabled = false;
                edCLI_INSCRICAO.Enabled = true;
                edCLI_FANTASIA.Enabled = true;
                edCLI_CNPJ.Enabled = true;
                edCLI_RAZAO.Enabled = true;
                btnAdd.Enabled = true;
                btnDel.Enabled = true;
            }
            else if(F.toString(rgCLI_PESTIPO.EditValue) == "FIS")
            {
                edCLI_INSCRICAO.Enabled = false;
                edCLI_CNPJ.Enabled = false;
                edCLI_RAZAO.Enabled = true;
                edCLI_FANTASIA.Enabled = false;
                edCLI_NASC.Enabled = true;
                btnAdd.Enabled = true;
                btnDel.Enabled = true;
            }
            else
            {
                edCLI_FANTASIA.Enabled = true;
                edCLI_CNPJ.Enabled = true;
                edCLI_RAZAO.Enabled = true;
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
                
            }
        }

        private void edCEP_Validated(object sender, EventArgs e)
        {
            F.LocalizarCEP(F.toString(edCEP.EditValue), edEstado, edCidade, edBairro, edRua);
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            FrmPets objFrmPets = new FrmPets("M");

            objFrmPets.DonoTemp = SqliteSequence.LastID("CLIENTE") + 1;

            if (objFrmPets.ShowDialog() == DialogResult.OK)
            {
                pets.Add(objFrmPets.NewPet);
                gridViewPet.RefreshData();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (F.toString(rgCLI_PESTIPO.EditValue) == "FIS" ) 
            {
                if (F.toString(edCLI_RAZAO) == "")
                {
                    F.Aviso("Por Favor, Informe o Nome do cliente.");
                    edCLI_RAZAO.Focus();
                }
                if (F.toString(edCLI_TEL.EditValue) == "" && F.toString(edCLI_CEL.EditValue) == ""
                && F.toString(edCLI_EMAIL.EditValue) == "")
                {
                    F.Aviso("Por favor, informa ao menos uma forma de contato.");
                }
                if (F.toString(edDDDCel.EditValue) == "" && F.toString(edCLI_CEL.EditValue) != "") 
                {
                    F.Aviso("Por Favor, Informe o DDD do celular.");
                    edDDDCel.Focus();
                }
                if (F.toString(edDDDTel.EditValue) == "" && F.toString(edCLI_TEL.EditValue) != "")
                {
                    F.Aviso("Por Favor, Informe o DDD do telefone.");
                    edDDDTel.Focus();
                }
            }
            if (F.toString(rgCLI_PESTIPO.EditValue) == "JUR")
            {
                if (F.toString(edCLI_RAZAO) == "")
                {
                    F.Aviso("Por favor, Informe a Razão Social do cliente");
                    edCLI_RAZAO.Focus();
                }
                if (F.toString(edCLI_FANTASIA.EditValue) == "")
                {
                    F.Aviso("Por favor, informe o nome fantasia do cliente");
                    edCLI_FANTASIA.Focus();
                }
                if (F.toString(edCLI_INSCRICAO) == "")
                {
                    F.Aviso("Por Favor, informe a Inscrição Estadual do cliente");
                    edCLI_INSCRICAO.Focus();
                }
                if (F.toString(edCLI_TEL.EditValue) == "" && F.toString(edCLI_CEL.EditValue) == ""
                && F.toString(edCLI_EMAIL.EditValue) == "")
                {
                    F.Aviso("Por favor, informa ao menos uma forma de contato.");
                }
                if (F.toString(edDDDCel.EditValue) == "" && F.toString(edCLI_CEL.EditValue) != "")
                {
                    F.Aviso("Por Favor, Informe o DDD do celular.");
                    edDDDCel.Focus();
                }
                if (F.toString(edDDDTel.EditValue) == "" && F.toString(edCLI_TEL.EditValue) != "")
                {
                    F.Aviso("Por Favor, Informe o DDD do telefone.");
                    edDDDTel.Focus();
                }
            }
            if (F.toString(rgCLI_PESTIPO.EditValue) == "FOR")
            {
                Fornecedor fornecedor = new Fornecedor
                {
                    FOR_RAZAO = F.toString(edCLI_RAZAO.EditValue),
                    FOR_FANTASIA = F.toString(edCLI_FANTASIA.EditValue),
                    FOR_DDDCEL = F.toString(edDDDCel.EditValue),
                    FOR_CEL = F.toString(edCLI_CEL.EditValue),
                    FOR_DDDTEL = F.toString(edDDDTel.EditValue),
                    FOR_TEL = F.toString(edCLI_TEL.EditValue),
                    FOR_EMAIL = F.toString(edCLI_EMAIL.EditValue),
                    FOR_CNPJ = F.toString(edCLI_CNPJ.EditValue),
                    FOR_CEP = F.toString(edCEP.EditValue),
                    FOR_UF = F.toString(edEstado.EditValue),
                    FOR_RUA = F.toString(edRua.EditValue),
                    FOR_NUMERO = F.toString(edNumero.EditValue),
                    FOR_COMPLEMENTO = F.toString(edComplemento.EditValue),
                    FOR_BAIRRO = F.toString(edBairro.EditValue),
                    FOR_DATA_CADASTRO = F.toString(DateTime.Now.ToShortDateString())
                };
                if (Fornecedor.Insert(fornecedor))
                {
                    F.Aviso("Fornecedor Cadastrado com sucesso");
                    Close();
                    return;
                }
                else
                {
                    F.Aviso("Erro ao cadastrar fornecedor!");
                    return;
                }
            }
            Clientes cliente = new Clientes
            {
                CLI_RAZAO = F.toString(edCLI_RAZAO.EditValue),
                CLI_FANTASIA = F.toString(edCLI_FANTASIA.EditValue),
                CLI_CNPJ = F.toString(edCLI_CNPJ.EditValue),
                CLI_EMAIL = F.toString(edCLI_EMAIL.EditValue),
                CLI_DDDCEL = F.toString(edDDDCel.EditValue),
                CLI_CEL = F.toString(edCLI_CEL.EditValue),
                CLI_DDDTEL = F.toString(edDDDTel.EditValue),
                CLI_TEL = F.toString(edCLI_TEL.EditValue),
                CLI_PESTIPO = (F.toString(rgCLI_PESTIPO.EditValue) == "FIS" ? "Física" : "Jurídica"),
                CLI_CEP = F.toString(edCEP.EditValue),
                CLI_RUA = F.toString(edRua.EditValue),
                CLI_BAIRRO = F.toString(edBairro.EditValue),
                CLI_NUMERO = F.toString(edNumero.EditValue),
                CLI_NASC = F.toString(edCLI_NASC.EditValue),
                CID_ID = F.toInt(edCidade.EditValue),
                CLI_INSCRICAO = F.toString(edCLI_INSCRICAO.EditValue)
                
            };
            if (Clientes.Insert(cliente))
            {
                foreach (Pets pet in pets)
                {
                    Pets petAdd = new Pets
                    {
                        PET_COR = pet.PET_COR,
                        PET_RACA = pet.PET_RACA,
                        PET_OBS = pet.PET_OBS,
                        PET_NOME = pet.PET_NOME,
                        PET_NAS = pet.PET_NAS,
                        PET_IMG = pet.PET_IMG,
                        CLI_ID = cliente.CLI_ID
                    };
                    Pets.Insert(petAdd);
                    
                }

                F.Aviso("Cliente Cadastrado com Sucesso!");
                Close();

            }
            else
            {
                F.Aviso("Erro ao Cadastrar Cliente");
            }
        }
    }
}
