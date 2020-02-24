using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardControl
{
    public partial class FrmPlaceHolder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //동적으로 컨트롤 생성
            //[1] 버튼 개체 하나 생성
            Button btn1 = new Button();
            btn1.ID = "btn1";
            btn1.Text = "버튼1";

            //이벤트 처리기 구현
            btn1.Click += btn_Click;

            //[2]PlaceHolder에 프로그래밍 방식으로 버튼 추가
            ctlPlaceHolder.Controls.Add(btn1);

            Literal ltr = new Literal();
            ltr.Text = "<br />";
            ctlPlaceHolder.Controls.Add(ltr);

            Button btn2 = new Button();
            btn2.ID = "btn2";
            btn2.Text = "버튼2";
            btn2.Click += btn_Click;
            ctlPlaceHolder.Controls.Add(btn2);


        }

        private void btn_Click(object sender, EventArgs e)
        {
            //플레이스 홀더의 btnClick개체를 찾아서 버튼 형태로 변환 후 Text속성 요청
            lblDisplay.Text = (sender as Button).Text + "버튼이 클릭되었습니다.<br/>";

            Button btnCurrent = sender as Button;
            lblDisplay.Text += btnCurrent.ID + "버튼입니다.<br />";

            //부모 컨트롤(컨테이너)로부터 자식 컨트롤을 읽어 오는 교과서다운 코드
            lblDisplay.Text += ((Button)ctlPlaceHolder.FindControl(btnCurrent.ID)).Text + "버튼이겠죠?";
        }
    }
}