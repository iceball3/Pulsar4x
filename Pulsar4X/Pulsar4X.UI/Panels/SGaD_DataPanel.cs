﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Pulsar4X.UI.Panels
{
    public partial class SGaD_DataPanel : DockContent
    {
        /// <summary>
        /// Returs the Planets Data Grid View
        /// </summary>
        public DataGridView PlanetsDataGrid
        {
            get
            {
                return m_oPlanetsDataGridView;
            }
        }

        /// <summary>
        /// Returns the Star Data Grid View
        /// </summary>
        public DataGridView StarDataGrid
        {
            get
            {
                return m_oStarDataGridView;
            }
        }

        public SGaD_DataPanel()
        {
            InitializeComponent();
        }
    }
}