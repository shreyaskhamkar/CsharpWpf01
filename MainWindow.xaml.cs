using System;
using System.Windows;

namespace CsharpWpf01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (!listbox1.Items.Contains(textBox1.Text))
            {
                String s = textBox1.Text;
                if (s.Contains("  ") || s.Contains("   "))
                {
                    MessageBox.Show("Remove extra spaces in your name");
                    return;
                }
                String s2 = s.Trim();

                listbox1.Items.Add(s2);
                textBox1.Clear();
            }
            else
                MessageBox.Show("The name is alerady present int the list");

            //    listbox1.Items.Add(textBox1.Text);
            //textBox1.Clear();

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {


            if (listbox1.SelectedItems.Count != 0)
            {
                while (listbox1.SelectedIndex != -1)
                {
                    listbox2.Items.Add(listbox1.SelectedItem);
                    listbox1.Items.Remove(listbox1.SelectedItem);


                }
            }
            else
                listbox1.Items.Clear();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {


            if (listbox2.SelectedItems.Count != 0)
            {
                while (listbox2.SelectedIndex != -1)
                {
                    listbox1.Items.Add(listbox2.SelectedItem);
                    listbox2.Items.Remove(listbox2.SelectedItem);


                }
            }
            else
                listbox1.Items.Clear();
        }


        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            listbox2.Items.Clear();

        }





    }

    //private void Button4_Click(object sender, RoutedEventArgs e)
    //{
    //    listbox1.Clear();
    //}



}

