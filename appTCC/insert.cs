using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace appTCC
{
    class insert : conexao
    {
        private DateTime tempo;
        private string reg_gas_cod;
        private string reg_incendio_cod;
        private string reg_proximidade_cod;
        private string reg_eletrica_cod;

        public void setTempo(DateTime tempo)
        {
            this.tempo = tempo;
        }
        public DateTime getTempo()
        {
            return this.tempo;
        }
        public void setReg_gas(string reg_gas_cod)
        {
            this.reg_gas_cod = reg_gas_cod;
        }
        public string getReg_gas()
        {
            return this.reg_gas_cod;
        }
        public void setReg_incendio(string reg_incendio_cod)
        {
            this.reg_incendio_cod = reg_incendio_cod;
        }
        public string getReg_incendio()
        {
            return this.reg_incendio_cod;
        }
        public void setReg_proximidade(string reg_proximidade_cod)
        {
            this.reg_proximidade_cod = reg_proximidade_cod;
        }
        public string getReg_proximidade()
        {
            return this.reg_proximidade_cod;
        }
        public void setReg_eletrica(string reg_eletrica_cod)
        {
            this.reg_eletrica_cod = reg_eletrica_cod;
        }
        public string getReg_eletrica()
        {
            return this.reg_eletrica_cod;
        }
        
        public void insert_dados()
        {

            string mSQL = "insert into proximidade (tempo, deteccao)values('" + getTempo().ToString("yyyy-MM-dd HH:m") + "', '" + getReg_proximidade() + "')";

            if (this.abriconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }
        public void insert_dados_incendio()
        {

            string mSQL = "insert into incendio (tempo, temperatura)values('" + getTempo().ToString("yyyy-MM-dd HH:m") + "', '" + getReg_incendio() + "')";

            if (this.abriconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void insert_dados_gas()
        {

            string mSQL = "insert into gas (tempo, deteccao)values('" + getTempo().ToString("yyyy-MM-dd HH:m") + "', '" + getReg_gas() + "')";

            if (this.abriconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        /*public void update_dados()
        {

            string mSQL = "update proximidade set tempo = '"+getTempo()+"', deteccao = '"+getReg_proximidade()+" where co";

            if (this.abriconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }*/ //Atualizar dados em vez de inserir um monte de dados
    }
}
