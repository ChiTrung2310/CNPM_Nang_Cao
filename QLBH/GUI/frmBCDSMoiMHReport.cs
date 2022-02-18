﻿using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmBCDSMoiMHReport : Form
    {
        public frmBCDSMoiMHReport()
        {
            InitializeComponent();
        }

        private void btBaocao_Click(object sender, EventArgs e)
        {
            //---------1.Khai báo CrystalReport: CR_MHTuDen.rpt
            CR_MHTuDen rp = new CR_MHTuDen();

            //---------2.Cung cấp thông tin đăng nhập cho CrystalReport (rp)
            ConnectionInfo myConn = new ConnectionInfo();
            TableLogOnInfo myTable = new TableLogOnInfo();
            myConn.ServerName = frmDangnhap.SV;
            myConn.DatabaseName = frmDangnhap.DB;
            myConn.UserID = frmDangnhap.UI;
            myConn.Password = frmDangnhap.Pass;
            myTable.ConnectionInfo = myConn;
            rp.Database.Tables[0].ApplyLogOnInfo(myTable);

            //---------3.Khai báo kết nối tham số với CrystalReport
            CrystalDecisions.Shared.ParameterValues myVL = new CrystalDecisions.Shared.ParameterValues();
            CrystalDecisions.Shared.ParameterDiscreteValue PDVTungay = new CrystalDecisions.Shared.ParameterDiscreteValue();
            CrystalDecisions.Shared.ParameterDiscreteValue PDVDenngay = new CrystalDecisions.Shared.ParameterDiscreteValue();

            //---------4.Truyền tham số Từ ngày - Đến ngày
            //-----4.1. Truyền tham số Từ ngày
            PDVTungay.Value = this.dTPTungay.Value;
            myVL.Add(PDVTungay);
            rp.DataDefinition.ParameterFields["@Tungay"].ApplyCurrentValues(myVL);
            myVL.Clear();
            //-----4.2. Truyền tham số Đến ngày
            PDVDenngay.Value = this.dTPDenngay.Value;
            myVL.Add(PDVDenngay);
            rp.DataDefinition.ParameterFields["@Denngay"].ApplyCurrentValues(myVL);
            myVL.Clear();

            //---------5.Gán CrystalReport (rp) vào crystalReportViewerP
            crystalReportViewerP.ReportSource = rp;

        }
    }
}
