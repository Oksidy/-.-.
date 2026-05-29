using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    // Объявление класса Form3, который наследует функционал стандартного окна Form
    public partial class Form3 : Form
    {
        // Конструктор класса Form3, вызываемый при создании окна
        public Form3()
        {
            // Обязательный метод инициализации всех визуальных элементов формы
            InitializeComponent();
        }

        // Обработчик события загрузки формы перед её отображением пользователю
        private void Form3_Load_1(object sender, EventArgs e)
        {
            // Присвоение текста с условием задачи компоненту richTextBox1
            richTextBox1.Text = "Определение положения изображения и линейного увеличения в тонкой линзе. Введите расстояние до предмета d0 и фокусное расстояние F.";
        }

        // Пользовательский метод для выполнения физических расчетов
        private void Calculate()
        {
            // Попытка преобразования текста из textBox1 (d0) и textBox2 (f) в числовой тип double
            // Если конвертация успешна, код выполняется дальше
            if (double.TryParse(textBox1.Text, out double d0) && double.TryParse(textBox2.Text, out double f))
            {
                // Проверка: если расстояние равно фокусному расстоянию
                if (d0 == f)
                {
                    // Вывод информационного окна о том, что изображение формируется в бесконечности
                    MessageBox.Show("Изображение формируется в бесконечности.", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Прерывание метода, так как дальнейшие расчеты невозможны
                    return;
                }
                // Проверка на физическую корректность: расстояние <= 0 или фокус = 0 (деление на ноль)
                if (d0 <= 0 || f == 0)
                {
                    // Вывод окна с предупреждением о некорректных данных
                    MessageBox.Show("Некорректные физические параметры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // Прерывание метода
                    return;
                }

                // Расчет оптической силы: 1 разделить на фокусное расстояние F
                double invF = 1.0 / f;
                // Расчет обратной величины расстояния до предмета: 1 разделить на d0
                double invD0 = 1.0 / d0;
                // Расчет обратной величины расстояния до изображения (по формуле тонкой линзы: 1/di = 1/F - 1/d0)
                double invDi = invF - invD0;
                // Нахождение искомого расстояния до изображения (di)
                double di = 1.0 / invDi;
                // Расчет линейного увеличения (Г = |di / d0|)
                double gamma = Math.Abs(di / d0);

                // Блок вывода хода решения. Форматирование "F3" и "F2" означает округление до 3 и 2 знаков после запятой
                textBox3.Text = invF.ToString("F3");  // Вывод значения 1/F
                textBox4.Text = invD0.ToString("F3"); // Вывод значения 1/d0
                textBox5.Text = invDi.ToString("F3"); // Вывод значения 1/di
                textBox6.Text = di.ToString("F2");    // Вывод значения di

                // Вывод параметров для формулы увеличения
                textBox7.Text = Math.Abs(di).ToString("F2"); // Вывод модуля di
                textBox8.Text = d0.ToString("F2");           // Вывод значения d0
                textBox9.Text = gamma.ToString("F2");        // Вывод вычисленного увеличения

                // Блок вывода итогового ответа
                textBox10.Text = di.ToString("F2");    // Итоговый ответ: расстояние di
                textBox11.Text = gamma.ToString("F2"); // Итоговый ответ: увеличение gamma
            }
            // Блок, выполняемый в случае провала конвертации текста в числа (введены буквы или пусто)
            else
            {
                // Вывод сообщения об ошибке ввода
                MessageBox.Show("Введите корректные числовые значения.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик события нажатия на первую кнопку (Расчет)
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Вызов метода расчетов
            Calculate();
        }

        // Обработчик события нажатия на вторую кнопку (Очистка)
        private void button2_Click_1(object sender, EventArgs e)
        {
            // Очистка всех используемых текстовых полей от содержимого
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
        }

        // Обработчик события нажатия на третью кнопку (Возврат в меню)
        private void button3_Click_1(object sender, EventArgs e)
        {
            // Создание нового экземпляра главной формы приложения
            Form1 form1 = new Form1();
            // Отображение созданной главной формы
            form1.Show();
            // Закрытие текущей формы (Form3) с высвобождением ресурсов
            this.Close();
        }

        // Системные обработчики изменения текста в полях
        // Оставлены пустыми, так как логика при вводе текста не требуется.
        // Их удаление вручную может вызвать ошибку в файле дизайнера формы.
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void textBox2_TextChanged_1(object sender, EventArgs e) { }
        private void textBox3_TextChanged_1(object sender, EventArgs e) { }
        private void textBox4_TextChanged_1(object sender, EventArgs e) { }
        private void textBox5_TextChanged_1(object sender, EventArgs e) { }
        private void textBox6_TextChanged_1(object sender, EventArgs e) { }
        private void textBox7_TextChanged_1(object sender, EventArgs e) { }
        private void textBox8_TextChanged_1(object sender, EventArgs e) { }
        private void textBox9_TextChanged_1(object sender, EventArgs e) { }
        private void textBox10_TextChanged_1(object sender, EventArgs e) { }
        private void textBox11_TextChanged_1(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged_1(object sender, EventArgs e) { }
    }
}