﻿using NotePadeFarsi.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NotePadeFarsi
{
    public partial class frmReplace : Form
    {
        MainForm mainForm;
        List<SearchResult> searchResults = new List<SearchResult>();
        int generalStartIndex = -1;
        public frmReplace(MainForm frmMain)
        {
            InitializeComponent();
            this.mainForm = frmMain;
        }

        private void frmReplace_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            string searchKey = txtBoxSearch.Text;
            int startIndex = 0;

            mainForm.richText.SelectionBackColor = mainForm.richText.BackColor;

            if (searchResults.Count() > 0)
            {
                ShowResultSelected(rdbJahatSearchDown.Checked);
                return;
            }
            else
            {
                searchResults = new List<SearchResult>();
            }

            while (startIndex < mainForm.richText.TextLength)
            {
                RichTextBoxFinds richTextBoxFinds = RichTextBoxFinds.None;

                if (rdbTypeSearchWord.Checked)
                {
                    richTextBoxFinds = RichTextBoxFinds.WholeWord;
                }

                int wordStartIndex = mainForm.richText.Find(searchKey, startIndex, richTextBoxFinds);

                if (wordStartIndex != -1)
                {
                    searchResults.Add(new SearchResult()
                    {
                        SelectionStart = wordStartIndex,
                        SelectionLength = searchKey.Length,
                        SearchKey = searchKey
                    });
                }
                else
                    break;

                startIndex = wordStartIndex + searchKey.Length;
            }

            ShowResultSelected(rdbJahatSearchDown.Checked);
        }

        private void ShowResultSelected(bool IsDown)
        {
            try
            {
                if (IsDown)
                {
                    generalStartIndex++;
                }
                else
                {
                    generalStartIndex--;
                }

                var selected = searchResults[generalStartIndex];

                mainForm.richText.SelectionStart = selected.SelectionStart;
                mainForm.richText.SelectionLength = selected.SelectionLength;
                mainForm.richText.SelectionBackColor = Color.Yellow;

                if (searchResults.Count <= generalStartIndex)
                {
                    generalStartIndex = 0;
                    searchResults = new List<SearchResult>();
                }
            }
            catch (System.Exception)
            {
                if (IsDown)
                {
                    generalStartIndex--;
                }
                else
                {
                    generalStartIndex++;
                }

                var selected = searchResults[generalStartIndex];

                mainForm.richText.SelectionStart = selected.SelectionStart;
                mainForm.richText.SelectionLength = selected.SelectionLength;
                mainForm.richText.SelectionBackColor = Color.Yellow;

                if (searchResults.Count <= generalStartIndex)
                {
                    generalStartIndex = 0;
                    searchResults = new List<SearchResult>();
                }
            }
        }

        private void frmClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.richText.SelectionBackColor = mainForm.richText.BackColor;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            Search();
            if (!string.IsNullOrEmpty(mainForm.richText.SelectedText))
            {
                mainForm.richText.SelectionBackColor = mainForm.richText.BackColor;
                mainForm.richText.SelectedText = mainForm.richText.SelectedText.Replace(mainForm.richText.SelectedText, txtReplace.Text);
            }
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            Search();
            if (!string.IsNullOrEmpty(mainForm.richText.SelectedText))
            {
                mainForm.richText.SelectionBackColor = mainForm.richText.BackColor;
                mainForm.richText.Text = mainForm.richText.Text.Replace(mainForm.richText.SelectedText, txtReplace.Text);
            }
        }
    }
}
