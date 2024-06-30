using System;

namespace AlexisSanchez_APPMobile.Views
{
    public partial class CalculateIMC : ContentPage
    {
        public CalculateIMC()
        {
            InitializeComponent();
        }

        private void OnClickCalculate(object sender, EventArgs e)
        {
            try
            {
                double weight = Convert.ToDouble(txtWeight.Text);
                double height = Convert.ToDouble(txtHeight.Text);
                double imc = weight / (height * height);

                string message;

                if (imc < 18.5)
                {
                    message = "Estás bajo de peso, busca un profesional que te ayude a estar en tu peso ideal.";
                }
                else if (imc >= 18.5 && imc < 24.9)
                {
                    message = "Estás en tu peso ideal, mantente así y si es necesario habla con un profesional para mantener tu peso.";
                }
                else
                {
                    message = "Estás con un peso más alto del ideal, busca un profesional que te ayude a estar en tu peso ideal.";
                }

                lblResult.Text = $"Tu IMC es {imc:F2}. {message}";
            }
            catch (FormatException)
            {
                lblResult.Text = "Por favor, ingrese valores numéricos válidos.";
            }
        }
    }
}