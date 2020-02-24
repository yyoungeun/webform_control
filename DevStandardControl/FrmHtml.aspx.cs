using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardControl
{
    public partial class FrmHtml : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //현재 페이지가 포스트백(재전송)이 아닐때만 바인딩, 즉 처음 로드 시에만 처리
            //코드 기반으로 데이터 추가
            if (!Page.IsPostBack)
            {
                ddlPhoneNumber.Items.Add("017");
                ddlPhoneNumber.Items.Add(new ListItem("016", "016"));
            }
        }
    }
}