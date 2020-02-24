using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevValidationControl
{
    public partial class FrmRequiredFieldValidator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //SetFocus()메서드 : 아이디 텍스트박스(특정 컨트롤)에 포커스
                Page.SetFocus(txtUserId);
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            //IsValid 속성 : 유효성 검사가 통과되면 true를 반환
            if (Page.IsValid)
            {
                Page.ClientScript.RegisterClientScriptBlock( //특정 자바스크립트 코드를 실행하는 기능을 하는데 첫 번째 매개변수의 값은 기본이다.
                    this.GetType(),
                    "alterMessage",
                    "<script>alert('통과');</script>");
            }
        }
    }
}