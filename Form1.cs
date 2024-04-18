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

            
            cbSexo.Items.Add("Masculino");
            cbSexo.Items.Add("Femenino");
            

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

            listPais.Add(new Pais() { ID = 0, Nombre = "Seleccione un pais..." });
            listPais.Add(new Pais() { ID = 1, Nombre = "Republica Dominicana" });
            listPais.Add(new Pais() { ID = 2, Nombre = "Estdos Unidos" });
            listPais.Add(new Pais() { ID = 3, Nombre = "España" });
            listPais.Add(new Pais() { ID = 4, Nombre = "México" });
            listPais.Add(new Pais() { ID = 5, Nombre = "Argentina" });
            listPais.Add(new Pais() { ID = 6, Nombre = "Brasil" });
            listPais.Add(new Pais() { ID = 7, Nombre = "Canadá" });
            listPais.Add(new Pais() { ID = 8, Nombre = "Francia" });
            listPais.Add(new Pais() { ID = 9, Nombre = "Alemania" });
            listPais.Add(new Pais() { ID = 10, Nombre = "Italia" });

            



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
            listProvincia.Add(new Provincia() { ID = 8, IdPais = 1, Nombre = "La Romana" });
            listProvincia.Add(new Provincia() { ID = 9, IdPais = 1, Nombre = "San Pedro de Macorís" });
            listProvincia.Add(new Provincia() { ID = 10, IdPais = 1, Nombre = "La Altagracia" });
            listProvincia.Add(new Provincia() { ID = 11, IdPais = 1, Nombre = "San Cristóbal" });
            listProvincia.Add(new Provincia() { ID = 12, IdPais = 1, Nombre = "La Vega" });
            listProvincia.Add(new Provincia() { ID = 13, IdPais = 1, Nombre = "Barahona" });
            listProvincia.Add(new Provincia() { ID = 14, IdPais = 1, Nombre = "Monte Plata" });
            listProvincia.Add(new Provincia() { ID = 15, IdPais = 3, Nombre = "Madrid" });
            listProvincia.Add(new Provincia() { ID = 16, IdPais = 3, Nombre = "Barcelona" });
            listProvincia.Add(new Provincia() { ID = 17, IdPais = 3, Nombre = "Valencia" });
            listProvincia.Add(new Provincia() { ID = 18, IdPais = 3, Nombre = "Sevilla" });
            listProvincia.Add(new Provincia() { ID = 19, IdPais = 3, Nombre = "Zaragoza" });
            listProvincia.Add(new Provincia() { ID = 20, IdPais = 3, Nombre = "Málaga" });
            listProvincia.Add(new Provincia() { ID = 21, IdPais = 3, Nombre = "Murcia" });
            listProvincia.Add(new Provincia() { ID = 22, IdPais = 3, Nombre = "Palma de Mallorca" });
            listProvincia.Add(new Provincia() { ID = 23, IdPais = 3, Nombre = "Las Palmas de Gran Canaria" });
            listProvincia.Add(new Provincia() { ID = 24, IdPais = 3, Nombre = "Bilbao" });
            listProvincia.Add(new Provincia() { ID = 25, IdPais = 2, Nombre = "Illinois" });
            listProvincia.Add(new Provincia() { ID = 26, IdPais = 2, Nombre = "Pennsylvania" });
            listProvincia.Add(new Provincia() { ID = 27, IdPais = 2, Nombre = "Georgia" });
            listProvincia.Add(new Provincia() { ID = 28, IdPais = 2, Nombre = "Ohio" });
            listProvincia.Add(new Provincia() { ID = 29, IdPais = 2, Nombre = "Michigan" });
            listProvincia.Add(new Provincia() { ID = 30, IdPais = 2, Nombre = "North Carolina" });
            listProvincia.Add(new Provincia() { ID = 31, IdPais = 2, Nombre = "New Jersey" });
            listProvincia.Add(new Provincia() { ID = 32, IdPais = 2, Nombre = "Virginia" });
            listProvincia.Add(new Provincia() { ID = 33, IdPais = 4, Nombre = "Ciudad de México" });
            listProvincia.Add(new Provincia() { ID = 34, IdPais = 4, Nombre = "Jalisco" });
            listProvincia.Add(new Provincia() { ID = 35, IdPais = 4, Nombre = "Nuevo León" });
            listProvincia.Add(new Provincia() { ID = 36, IdPais = 4, Nombre = "Veracruz" });
            listProvincia.Add(new Provincia() { ID = 37, IdPais = 4, Nombre = "Puebla" });
            listProvincia.Add(new Provincia() { ID = 38, IdPais = 4, Nombre = "Guanajuato" });
            listProvincia.Add(new Provincia() { ID = 39, IdPais = 4, Nombre = "Chiapas" });
            listProvincia.Add(new Provincia() { ID = 40, IdPais = 4, Nombre = "Michoacán" });
            listProvincia.Add(new Provincia() { ID = 41, IdPais = 4, Nombre = "Sonora" });
            listProvincia.Add(new Provincia() { ID = 42, IdPais = 4, Nombre = "Chihuahua" });
            listProvincia.Add(new Provincia() { ID = 43, IdPais = 5, Nombre = "Buenos Aires" });
            listProvincia.Add(new Provincia() { ID = 44, IdPais = 5, Nombre = "Córdoba" });
            listProvincia.Add(new Provincia() { ID = 45, IdPais = 5, Nombre = "Santa Fe" });
            listProvincia.Add(new Provincia() { ID = 46, IdPais = 5, Nombre = "Mendoza" });
            listProvincia.Add(new Provincia() { ID = 47, IdPais = 5, Nombre = "Tucumán" });
            listProvincia.Add(new Provincia() { ID = 48, IdPais = 5, Nombre = "Entre Ríos" });
            listProvincia.Add(new Provincia() { ID = 49, IdPais = 5, Nombre = "Salta" });
            listProvincia.Add(new Provincia() { ID = 50, IdPais = 5, Nombre = "Misiones" });
            listProvincia.Add(new Provincia() { ID = 51, IdPais = 5, Nombre = "Neuquén" });
            listProvincia.Add(new Provincia() { ID = 52, IdPais = 5, Nombre = "San Juan" });
            listProvincia.Add(new Provincia() { ID = 53, IdPais = 6, Nombre = "São Paulo" });
            listProvincia.Add(new Provincia() { ID = 54, IdPais = 6, Nombre = "Rio de Janeiro" });
            listProvincia.Add(new Provincia() { ID = 55, IdPais = 6, Nombre = "Bahia" });
            listProvincia.Add(new Provincia() { ID = 56, IdPais = 6, Nombre = "Minas Gerais" });
            listProvincia.Add(new Provincia() { ID = 57, IdPais = 6, Nombre = "Rio Grande do Sul" });
            listProvincia.Add(new Provincia() { ID = 58, IdPais = 6, Nombre = "Paraná" });
            listProvincia.Add(new Provincia() { ID = 59, IdPais = 6, Nombre = "Pernambuco" });
            listProvincia.Add(new Provincia() { ID = 60, IdPais = 6, Nombre = "Santa Catarina" });
            listProvincia.Add(new Provincia() { ID = 61, IdPais = 6, Nombre = "Ceará" });
            listProvincia.Add(new Provincia() { ID = 62, IdPais = 6, Nombre = "Goiás" });
            listProvincia.Add(new Provincia() { ID = 63, IdPais = 7, Nombre = "Ontario" });
            listProvincia.Add(new Provincia() { ID = 64, IdPais = 7, Nombre = "Quebec" });
            listProvincia.Add(new Provincia() { ID = 65, IdPais = 7, Nombre = "British Columbia" });
            listProvincia.Add(new Provincia() { ID = 66, IdPais = 7, Nombre = "Alberta" });
            listProvincia.Add(new Provincia() { ID = 67, IdPais = 7, Nombre = "Manitoba" });
            listProvincia.Add(new Provincia() { ID = 68, IdPais = 7, Nombre = "Saskatchewan" });
            listProvincia.Add(new Provincia() { ID = 69, IdPais = 7, Nombre = "Nova Scotia" });
            listProvincia.Add(new Provincia() { ID = 70, IdPais = 7, Nombre = "New Brunswick" });
            listProvincia.Add(new Provincia() { ID = 71, IdPais = 7, Nombre = "Newfoundland and Labrador" });
            listProvincia.Add(new Provincia() { ID = 72, IdPais = 7, Nombre = "Prince Edward Island" });
            listProvincia.Add(new Provincia() { ID = 73, IdPais = 8, Nombre = "Île-de-France" });
            listProvincia.Add(new Provincia() { ID = 74, IdPais = 8, Nombre = "Auvergne-Rhône-Alpes" });
            listProvincia.Add(new Provincia() { ID = 75, IdPais = 8, Nombre = "Occitanie" });
            listProvincia.Add(new Provincia() { ID = 76, IdPais = 8, Nombre = "Hauts-de-France" });
            listProvincia.Add(new Provincia() { ID = 77, IdPais = 8, Nombre = "Provence-Alpes-Côte d'Azur" });
            listProvincia.Add(new Provincia() { ID = 78, IdPais = 8, Nombre = "Nouvelle-Aquitaine" });
            listProvincia.Add(new Provincia() { ID = 79, IdPais = 8, Nombre = "Grand Est" });
            listProvincia.Add(new Provincia() { ID = 80, IdPais = 8, Nombre = "Pays de la Loire" });
            listProvincia.Add(new Provincia() { ID = 81, IdPais = 8, Nombre = "Bretagne" });
            listProvincia.Add(new Provincia() { ID = 82, IdPais = 8, Nombre = "Normandie" });
            listProvincia.Add(new Provincia() { ID = 83, IdPais = 9, Nombre = "Nordrhein-Westfalen" });
            listProvincia.Add(new Provincia() { ID = 84, IdPais = 9, Nombre = "Bayern" });
            listProvincia.Add(new Provincia() { ID = 85, IdPais = 9, Nombre = "Baden-Württemberg" });
            listProvincia.Add(new Provincia() { ID = 86, IdPais = 9, Nombre = "Niedersachsen" });
            listProvincia.Add(new Provincia() { ID = 87, IdPais = 9, Nombre = "Hessen" });
            listProvincia.Add(new Provincia() { ID = 88, IdPais = 9, Nombre = "Rheinland-Pfalz" });
            listProvincia.Add(new Provincia() { ID = 89, IdPais = 9, Nombre = "Berlin" });
            listProvincia.Add(new Provincia() { ID = 90, IdPais = 9, Nombre = "Schleswig-Holstein" });
            listProvincia.Add(new Provincia() { ID = 91, IdPais = 9, Nombre = "Brandenburg" });
            listProvincia.Add(new Provincia() { ID = 92, IdPais = 9, Nombre = "Sachsen" });
            listProvincia.Add(new Provincia() { ID = 93, IdPais = 10, Nombre = "Lombardia" });
            listProvincia.Add(new Provincia() { ID = 94, IdPais = 10, Nombre = "Lazio" });
            listProvincia.Add(new Provincia() { ID = 95, IdPais = 10, Nombre = "Campania" });
            listProvincia.Add(new Provincia() { ID = 96, IdPais = 10, Nombre = "Sicilia" });
            listProvincia.Add(new Provincia() { ID = 97, IdPais = 10, Nombre = "Veneto" });
            listProvincia.Add(new Provincia() { ID = 98, IdPais = 10, Nombre = "Emilia-Romagna" });
            listProvincia.Add(new Provincia() { ID = 99, IdPais = 10, Nombre = "Piemonte" });
            listProvincia.Add(new Provincia() { ID = 100, IdPais = 10, Nombre = "Toscana" });
            listProvincia.Add(new Provincia() { ID = 101, IdPais = 10, Nombre = "Calabria" });
            listProvincia.Add(new Provincia() { ID = 102, IdPais = 10, Nombre = "Puglia" });








        }
        
        public void Sexo() 
        {
            cbSexo.Items.Add(new Sexo() { Masculino = "Masculino" });
            cbSexo.Items.Add(new Sexo() { Femenino = "Femenino" });
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
            MessageBox.Show("Informaciones basicas guardadas exitosamente.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSexo = cbSexo.SelectedItem.ToString();

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

        private void Nombre_del_Paciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttBorrar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Datos borrados correctamente.");
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

