﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Winform.FullStackll.Defaults;
using Winform.FullStackll.DTOS;
using Winform.FullStackll.Entities;

namespace Winform.FullStackll.Forms
{
    public partial class NotesForm : Form
    {
        UserLoginResponseDto responseDto;

        Note selectedNote = null;

        public NotesForm(UserLoginResponseDto responseDto)
        {
            InitializeComponent();
            this.responseDto = responseDto;
            Reload();
        }

        private void Reload()
        {
            var notes = ListNote();
            ListNotes.DataSource = null;
            ListNotes.DataSource = notes;
            ListNotes.DisplayMember = "Description";
            ListNotes.ValueMember = "Id";

        }

        private void ClearText()
        {
            txtDescription.Text = string.Empty;
        }

        private List<Note> ListNote()
        {
            var notes = new List<Note>();

            if (responseDto != null)
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "select * from Notes where UserId=@userId";

                command.Parameters.AddWithValue("@userId", responseDto.Id);

                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var note = new Note();
                    note.Id = Convert.ToInt32(reader[0]);
                    note.Description = Convert.ToString(reader[1]);
                    note.UserId = Convert.ToInt32(reader[2]);

                    notes.Add(note);

                }
                reader.Close();
                connection.Close();
                command.Parameters.Clear();
            }


            return notes;

        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListNotes.SelectedItem != null)
            {
                selectedNote = ListNotes.SelectedItem as Note;
                txtDescription.Text = selectedNote.Description;
            }


        }

        private void NotesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NotesForm_Load(object sender, EventArgs e)
        {
            lblUser.Text = responseDto.Fullname;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDescription.Text) && responseDto != null)
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "insert into Notes values(@description,@userId)";

                command.Parameters.AddWithValue("@description", txtDescription.Text);
                command.Parameters.AddWithValue("@userId", responseDto.Id);

                connection.Open();
                var effectedRows = command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();

                if (effectedRows > 0)
                {
                    MessageBox.Show(MessageDefaults.SUCCESS);
                    Reload();
                    ClearText();
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ClearText();
            selectedNote = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedNote != null && !string.IsNullOrEmpty(txtDescription.Text))
            {
                SqlConnection connection = new SqlConnection("server=.\\SQLExpress; database=TutorialDb; integrated security=true;");
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.Connection = connection;
                command.CommandText = "update Notes Set Description = @description where Id=@id";

                command.Parameters.AddWithValue("@description", txtDescription.Text);
                command.Parameters.AddWithValue("@id", selectedNote.Id);


                connection.Open();
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                connection.Close();

                Reload();
                ClearText();
            }
            else
            {
                MessageBox.Show(MessageDefaults.NOTE_NOT_SELLECTED);
            }
        }
    }
}
