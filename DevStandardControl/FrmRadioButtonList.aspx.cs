﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardControl
{
    public partial class FrmRadioButtonList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //empty
        }

        protected void btnOK_Click(object sender, EventArgs e)
        {
            string strMsg = ""; //empty
            if(lstWedding.SelectedItem.Text == "미혼")
            {
                strMsg = "미혼을 선택하셨습니다.";
            }
            else
            {
                strMsg = lstWedding.SelectedValue + "을 선택하셨습니다.";
            }
            Response.Write($"{strMsg} <br/>");
        }
    }
}