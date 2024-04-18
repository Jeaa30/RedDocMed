using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RedDocMed2
{
    public partial class Form1 : Form
    {
        List<Pais> listPais = new List<Pais>();
        List<Provincia> listProvincia = new List<Provincia>();
        List <Sexo> listSexo = new List<Sexo>();

        private DateTime fechaChequeoPrismatico;
        private DateTime fechaPrimeraMenstruacion;
        private DateTime fechaRealizacionPSA;
        private DateTime fechaChequeoMamario;

        
        public Form1()
        {

            InitializeComponent();
            
            //Alimentando el Combo Box Pais
            ProcedenciaPais();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = listPais;

            cbPais.DataSource = bindingSource1.DataSource;

            cbPais.DisplayMember = "Nombre";
            cbPais.ValueMember = "ID";

            

        }





        public void ProcedenciaPais()
        {
            listPais.Add(new Pais() { ID = 1, Nombre = "Republica Dominicana" });
            listPais.Add(new Pais() { ID = 2, Nombre = "Estdos Unidos" });
            listPais.Add(new Pais() { ID = 3, Nombre = "España" });

        }

        public void ProcedenciaProvincia()
        {
            listProvincia.Add(new Provincia() { ID = 1, IdPais = 1, Nombre = "Santo Domingo" });
            listProvincia.Add(new Provincia() { ID = 2, IdPais = 1, Nombre = "Santiago" });
            listProvincia.Add(new Provincia() { ID = 3, IdPais = 1, Nombre = "Puerto Plata" });
            listProvincia.Add(new Provincia() { ID = 4, IdPais = 2, Nombre = "Nueva York" });
            listProvincia.Add(new Provincia() { ID = 5, IdPais = 2, Nombre = "Washington D.C." });
            listProvincia.Add(new Provincia() { ID = 6, IdPais = 3, Nombre = "Madrid" });
            listProvincia.Add(new Provincia() { ID = 7, IdPais = 3, Nombre = "Barcelona" });

        }



        private void cbPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int IdPais = (int)cbPais.SelectedValue;
            listProvincia.Clear();
            ProcedenciaProvincia();
            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = listProvincia.Where(c => c.IdPais == IdPais).ToList();

            cbProvincia.DataSource = bindingSource1.DataSource;

            cbProvincia.DisplayMember = "Nombre";
            cbProvincia.ValueMember = "ID";
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            string Nombre = Nombre_del_Paciente.Text;
            string Apellido = Apellido_del_Paciente.Text;
            string Pais = cbPais.Items.ToString();
            string Provincia = cbProvincia.Items.ToString();
            string Direccion = txtDireccion.Text;
            
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Femenino");
        }

        private  void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void si_habitos_toxicos_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void no_habitos_toxicos_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private void si_fumador_CheckedChanged(object sender, EventArgs e)
        {
            if (si_fumador.Checked)
            {
                no_fumador.Checked = true;
            }
        }

        private void no_fumador_CheckedChanged(object sender, EventArgs e)
        {
            if (no_fumador.Checked)
            {
                si_fumador.Checked = true;
            }
        }

        private void si_alcoholico_CheckedChanged(object sender, EventArgs e)
        {
            if (si_alcoholico.Checked)
            {
                no_alcoholico.Checked = true;
            }
        }

        private void no_alcoholico_CheckedChanged(object sender, EventArgs e)
        {
            if (no_alcoholico.Checked)
            {
                si_alcoholico.Checked = true;
            }
        }

        private void si_alergico_CheckedChanged(object sender, EventArgs e)
        {
            if (si_alergico.Checked)
            {
                no_alergico.Checked = true;
            }
        }

        private void no_alergico_CheckedChanged(object sender, EventArgs e)
        {
            if (no_alergico.Checked)
            {
                si_alergico.Checked = true;
            }
        }

        private void guardar2_Click(object sender, EventArgs e)
        {
            if (AllOptionsSelected() && AllTextboxesFilled())
            {
                string antecedentesText = "";

                if (si_habitos_toxicos.Checked)
                {
                    antecedentesText += "Hábitos tóxicos: Sí\n";
                    
                }
                else if (no_habitos_toxicos.Checked)
                {
                    antecedentesText += "Hábitos tóxicos: No\n";
                }

                if (si_fumador.Checked)
                {
                    antecedentesText += "Fumador: Sí\n";
                }
                else if (no_fumador.Checked)
                {
                    antecedentesText += "Fumador: No\n";
                }

                if (si_alcoholico.Checked)
                {
                    antecedentesText += "Alcohólico: Sí\n";
                }
                else if (no_alcoholico.Checked)
                {
                    antecedentesText += "Alcohólico: No\n";
                }

                if (si_alergico.Checked)
                {
                    antecedentesText += "Alergico: Sí\n";
                    antecedentesText += "Especificación: " + especificacion_alergico.Text + "\n";
                }
                else if (no_alergico.Checked)
                {
                    antecedentesText += "Alergico: No\n";
                }

                MessageBox.Show(antecedentesText, "Antecedentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione todas las opciones y especifique en los campos correspondientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        private bool AllOptionsSelected()
        {
            return (si_habitos_toxicos.Checked || no_habitos_toxicos.Checked) &&
                   (si_fumador.Checked || no_fumador.Checked) &&
                   (si_alcoholico.Checked || no_alcoholico.Checked) &&
                   (si_alergico.Checked || no_alergico.Checked);
        }

        private bool AllTextboxesFilled()
        {
            return !string.IsNullOrEmpty(especificacion_habito.Text) &&
                   !string.IsNullOrEmpty(especificacion_alergico.Text);
        }

        

        

        private void SiCancer_CheckedChanged(object sender, EventArgs e)
        {
            // Aquí puedes realizar acciones relacionadas con el cambio de estado en SiCancer
            bool estaMarcado = SiCancer.Checked;
            // Por ejemplo, podrías habilitar o deshabilitar otros controles en función de la selección
        }

        private void NoCancer_CheckedChanged(object sender, EventArgs e)
        {
            // Aquí puedes realizar acciones relacionadas con el cambio de estado en NoCancer
            bool estaMarcado = NoCancer.Checked;
            // Por ejemplo, podrías habilitar o deshabilitar otros controles en función de la selección
        }

        private void Cancer_txt_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes realizar acciones relacionadas con el cambio de texto en Cancer_txt
            string texto = Cancer_txt.Text;
            // Por ejemplo, podrías validar si el texto ingresado es válido para un campo de cáncer
        }


        private void Guardar_condicion_Click(object sender, EventArgs e)
        {
            // Aquí puedes implementar la lógica para guardar las condiciones médicas ingresadas por el usuario
            
            
            bool tieneCancer = SiCancer.Checked;
            string tipoCancer = Cancer_txt.Text;

            // Por ejemplo, podrías guardar esta información en una base de datos o en algún otro lugar
            // Aquí solo se muestra un mensaje de confirmación
            MessageBox.Show("Condiciones médicas guardadas exitosamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Borrar_condicion_Click(object sender, EventArgs e)
        {
            // Aquí puedes implementar la lógica para borrar o limpiar las condiciones médicas ingresadas por el usuario
            
            
            SiCancer.Checked = false;
            Cancer_txt.Text = "";

            // Aquí solo se muestra un mensaje de confirmación
            MessageBox.Show("Condiciones médicas borradas exitosamente.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PresionArterial_TextChanged(object sender, EventArgs e)
        {
            string texto = PresionArterial.Text;
        }

        private void FrecuenciaRespiratoria_TextChanged(object sender, EventArgs e)
        {
            string texto = FrecuenciaRespiratoria.Text;
        }

        private void FrecuenciaCardiaca_TextChanged(object sender, EventArgs e)
        {
            string texto = FrecuenciaCardiaca.Text;
        }

        private void Saturacion_TextChanged(object sender, EventArgs e)
        {
            string texto = Saturacion.Text;
        }

        private void Temperatura_TextChanged(object sender, EventArgs e)
        {
            string texto = Temperatura.Text;
        }

        private void MotivosDeConsulta_TextChanged(object sender, EventArgs e)
        {
            string texto = MotivosDeConsulta.Text;
        }

        private void Guardar3_Click(object sender, EventArgs e)
        {
            string presionArterial = PresionArterial.Text;
            string frecuenciaRespiratoria = FrecuenciaRespiratoria.Text;
            string frecuenciaCardiaca = FrecuenciaCardiaca.Text;
            string saturacion = Saturacion.Text;
            string temperatura = Temperatura.Text;
            string motivosDeConsulta = MotivosDeConsulta.Text;
            MessageBox.Show("Resultados de Examen Fisico guardadas exitosamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void Borrar3_Click(object sender, EventArgs e)
        {
            PresionArterial.Text = "";
            FrecuenciaRespiratoria.Text = "";
            FrecuenciaCardiaca.Text = "";
            Saturacion.Text = "";
            Temperatura.Text = "";
            MotivosDeConsulta.Text = "";
            MessageBox.Show("Resultados de Examen Fisico borradas exitosamente.", "Borrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guardar_3_Click(object sender, EventArgs e)
        {
            // Verificar si alguna fecha está vacía o es posterior a la fecha actual
            if (fechaChequeoPrismatico == DateTime.MinValue ||
                fechaPrimeraMenstruacion == DateTime.MinValue ||
                fechaRealizacionPSA == DateTime.MinValue ||
                fechaChequeoMamario == DateTime.MinValue ||
                fechaChequeoPrismatico > DateTime.Now ||
                fechaPrimeraMenstruacion > DateTime.Now ||
                fechaRealizacionPSA > DateTime.Now ||
                fechaChequeoMamario > DateTime.Now)
            {
                // Mostrar un mensaje indicando que se debe seleccionar una fecha válida
                MessageBox.Show("Por favor, seleccione una fecha válida anterior a la fecha actual.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin guardar las fechas
            }

            // Aquí puedes agregar el código para guardar las fechas en la base de datos o realizar otras operaciones
            // ...

            // Mostrar un mensaje de confirmación
            MessageBox.Show("Datos guardados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void chequeo_prismatico_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Actualizar la variable fechaChequeoPrismatico con la fecha seleccionada
            fechaChequeoPrismatico = PrimeraMesntruacion.SelectionStart;
        }

        private void primera_menstruacion_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Actualizar la variable fechaPrimeraMenstruacion con la fecha seleccionada
            fechaPrimeraMenstruacion = PAPANICOLAU.SelectionStart;
        }

        private void realizacion_psa_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Actualizar la variable fechaRealizacionPSA con la fecha seleccionada
            fechaRealizacionPSA = realizacion_psa.SelectionStart;
        }

        private void chequeo_mamario_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Actualizar la variable fechaChequeoMamario con la fecha seleccionada
            fechaChequeoMamario = PSA.SelectionStart;
        }

        private void borrar_3_Click(object sender, EventArgs e)
        {
            // Limpiar las fechas seleccionadas estableciéndolas en un valor predeterminado
            fechaChequeoPrismatico = DateTime.MinValue;
            fechaPrimeraMenstruacion = DateTime.MinValue;
            fechaRealizacionPSA = DateTime.MinValue;
            fechaChequeoMamario = DateTime.MinValue;

            // Limpiar también los controles de calendario si es necesario
            PrimeraMesntruacion.SetDate(DateTime.Now);
            PAPANICOLAU.SetDate(DateTime.Now);
            realizacion_psa.SetDate(DateTime.Now);
            PSA.SetDate(DateTime.Now);

            // Puedes agregar cualquier otra lógica de limpieza que necesites aquí

            // O simplemente mostrar un mensaje de confirmación
            MessageBox.Show("Fechas borradas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void si_fumador_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void PrimeraMesntruacion_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = PrimeraMesntruacion.SelectionStart;
            MessageBox.Show("La fecha de la primera menstruación ha sido cambiada a: " + fechaSeleccionada.ToShortDateString());
        }

        // Método llamado cuando se cambia la fecha en el control ChequeoMAMA
        private void ChequeoMAMA_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = ChequeoMAMA.SelectionStart;
            MessageBox.Show("La fecha del chequeo de mama ha sido cambiada a: " + fechaSeleccionada.ToShortDateString());
        }

        // Método llamado cuando se cambia la fecha en el control PSA
        private void PSA_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = PSA.SelectionStart;
            MessageBox.Show("La fecha del PSA ha sido cambiada a: " + fechaSeleccionada.ToShortDateString());
            // Aquí puedes incluir la lógica para realizar pruebas de Antígeno Prostático Específico
        }

        // Método llamado cuando se cambia la fecha en el control PAPANICOLAU
        private void PAPANICOLAU_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = PAPANICOLAU.SelectionStart;
            MessageBox.Show("La fecha del Papanicolau ha sido cambiada a: " + fechaSeleccionada.ToShortDateString());
            // Aquí puedes incluir la lógica para realizar exámenes ginecológicos de Papanicolau
        }
     

        private void Guardar5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos guardados correctamente.");
        }

        private void Borrar5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Datos borrados correctamente.");
        }

        private void borrar2_Click(object sender, EventArgs e)
        {

        }

        private void especificacion_habito_TextChanged(object sender, EventArgs e)
        {

        }

        private void no_fumador_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void si_alcoholico_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Si_TS_CheckedChanged(object sender, EventArgs e)
        {
            if (Si_TS.Checked)
            {
                MessageBox.Show("Se seleccionó Sí en Tensión Sistólica");
            }
        }

        private void No_TS_CheckedChanged(object sender, EventArgs e)
        {
            if (No_TS.Checked)
            {
                MessageBox.Show("Se seleccionó No en Tensión Sistólica");
            }
        }

        private void Si_Diab_CheckedChanged(object sender, EventArgs e)
        {
            if (Si_Diab.Checked)
            {
                MessageBox.Show("Se seleccionó Sí en Diabetes");
            }
        }

        private void No_Diab_CheckedChanged(object sender, EventArgs e)
        {
            if (No_Diab.Checked)
            {
                MessageBox.Show("Se seleccionó No en Diabetes");
            }
        }

        private void Si_Hiper_CheckedChanged(object sender, EventArgs e)
        {
            if (Si_Hiper.Checked)
            {
                MessageBox.Show("Se seleccionó Sí en Hipertensión");
            }
        }

        private void No_Hiper_CheckedChanged(object sender, EventArgs e)
        {
            if (No_Hiper.Checked)
            {
                MessageBox.Show("Se seleccionó No en Hipertensión");
            }
        }

        private void Si_HIPRTDI_CheckedChanged(object sender, EventArgs e)
        {
            if (Si_HIPRTDI.Checked)
            {
                MessageBox.Show("Se seleccionó Sí en Hipertensión de Tratamiento Diario");
            }
        }

        private void NO_HIPRTD_CheckedChanged(object sender, EventArgs e)
        {
            if (NO_HIPRTD.Checked)
            {
                MessageBox.Show("Se seleccionó No en Hipertensión de Tratamiento Diario");
            }
        }

        private void Si_Hipo_CheckedChanged(object sender, EventArgs e)
        {
            if (Si_Hipo.Checked)
            {
                MessageBox.Show("Se seleccionó Sí en Hipotiroidismo");
            }
        }

        private void No_Hipo_CheckedChanged(object sender, EventArgs e)
        {
            if (No_Hipo.Checked)
            {
                MessageBox.Show("Se seleccionó No en Hipotiroidismo");
            }
        }

        private void Guardar6_Click(object sender, EventArgs e)
        {
            string MotivosDeConsulta = MTVTEXT.Text;
            MessageBox.Show(MTVTEXT.Text);
        }

        private void Guradar6_Click(object sender, EventArgs e)
        {
            
        }

        private void Guardar6_Click_1(object sender, EventArgs e)
        {
            string MotivosDeConsulta = MTVTEXT.Text;
            MessageBox.Show(MTVTEXT.Text);
        }

        private void Borrar6_Click(object sender, EventArgs e)
        {
            MTVTEXT.Text = "";
            MessageBox.Show("Informacion Borrada");
        }
    }
}



    public class Pais
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
    }

    public class Provincia
    {
        public int ID { get; set; }
        public int IdPais { get; set; }
        public string Nombre { get; set; }
    }

    public class Sexo
    {
        public string Masculino { get; set; }
        public string Femenino { get; set; }
    }

