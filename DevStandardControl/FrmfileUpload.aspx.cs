using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DevStandardControl
{
    public partial class FrmfileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //empty
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            //[1]파일이 첨부되었다면
            if (ctlFileUpload.HasFile)
            {

                //업로드 : 같은 경로의 files라는 폴더에 
                //넘겨져온 파일면(폴더명)으로 저장
                //[2] App_Data 폴더로 파일 업로드
                ctlFileUpload.SaveAs(Server.MapPath(".") + "/files/" + ctlFileUpload.FileName);

                //[3]다운로드 링크 만들기
                lblResult.Text = String.Format("<a href='{0}{1}'>{2}</a>", "./files/", Server.UrlPathEncode(ctlFileUpload.FileName), ctlFileUpload.FileName);
            }
        }
    }
}