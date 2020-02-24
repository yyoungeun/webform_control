using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardControl
{
    public partial class FrmDropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //페이지가 로드될 때 드롭다운리스트의 항목이 한 개이상이라면 1의 인덱스에 위치한 '공무원'을 선택한 상태로 보여준다.
            if(!Page.IsPostBack && lstJob.Items.Count > 1)
            {
                this.lstJob.SelectedIndex = 1;
            }
        }

        protected void lstJob_SelectedindexChanged(object sender, EventArgs e) //이벤트 발생
        {
            //문자열 변수 선언과 동시 초기화
            string strMsg = String.Empty;
            strMsg = lstJob.SelectedItem.Text + "을(를) 선택하셨습니다.";
            //레이블에 현재 선택된 값 출력
            this.lblDisplay.Text = strMsg;
        }
    }
}