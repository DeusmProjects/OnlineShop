﻿using ImplementDB;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ViewForm
{
    public partial class CreateForm : Form
    {
        [Dependency] public new IUnityContainer Container { get; set; }

        public int Id { set { id = value; } }

        private readonly IMainService service;

        private int? id;

        public CreateForm(IMainService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            controlListBoxSelected1.LoadEnumeration( new List<string> { "Москва", "Ульяновск", "Киев" });            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(controlTextBoxEmail1.EmailText))
            {
                MessageBox.Show("Заполните Email", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                //if (id.HasValue)
                //{
                //    service.UpdElement(new CustomerBindingModel
                //    {
                //        Id = id.Value,
                //        CustomerFIO = textBoxFIO.Text
                //    });
                //}
                //else
                {
                    service.AddElement(new Main
                    {
                        City = controlListBoxSelected1.SelectedText,
                        Email = controlTextBoxEmail1.EmailText
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information); DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
