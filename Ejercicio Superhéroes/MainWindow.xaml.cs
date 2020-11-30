
using System.Collections.Generic;

using System.Windows;


namespace Ejercicio_Superhéroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Superheroe> listS;
        int contador = 0;
        int numero = 1;

        public MainWindow()
        {
            InitializeComponent();

            listS = Superheroe.GetSamples();
            nombreTextBlock.DataContext = listS;
            imagenImage.DataContext = listS;
            contadorTextBlock.Text = numero + " /";
            listaCountTextBlock.Text = listS.Count + "";
        }

        private void pasar_Click(object sender, RoutedEventArgs e)
        {
            numero++;
            contador++;               
            contadorTextBlock.Text = numero + " /";
            listaCountTextBlock.Text = listS.Count + "";
            nombreTextBlock.DataContext = listS[contador];
            imagenImage.DataContext = listS[contador];
                       
        }

        private void volver_Click(object sender, RoutedEventArgs e)
        {
            numero--;
            contador--;           
            contadorTextBlock.Text = numero + " /";
            listaCountTextBlock.Text = listS.Count + "";
            nombreTextBlock.DataContext = listS[contador];
            imagenImage.DataContext = listS[contador];
            
        }    

        private void villanoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            vengadoresCheckBox.IsEnabled = false;
            vengadoresCheckBox.IsEnabled = false;
        }

        private void villanoRadioButton_Unchecked(object sender, RoutedEventArgs e)
        {
            vengadoresCheckBox.IsEnabled = true;
            xmenCheckBox.IsEnabled = true;
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            nombreTextBox.Text = "";
            imagenTextBox.Text = "";
        }

        private void aceptarButton_Click(object sender, RoutedEventArgs e)
        {
            Superheroe superHeroe = new Superheroe();
            superHeroe.Nombre = nombreTextBox.Text;
            superHeroe.Imagen = imagenTextBox.Text;
            if(heroeRadioButton.IsChecked ==true)
            {
               superHeroe.Heroe = true;
                if (vengadoresCheckBox.IsChecked == true)
                {
                    superHeroe.Vengador = true;
                }
                else superHeroe.Vengador = false;

                if (xmenCheckBox.IsChecked == true)
                {
                    superHeroe.Xmen = true;
                }
                else superHeroe.Xmen = false;


            }
            else
            {
                superHeroe.Villano = true;
            }

            listS.Add(superHeroe);
        }
    }
}
