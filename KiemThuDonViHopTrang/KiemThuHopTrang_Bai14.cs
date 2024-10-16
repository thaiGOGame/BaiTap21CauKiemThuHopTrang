using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai14
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data14.csv", "data14#csv", DataAccessMethod.Sequential), DeploymentItem("data14.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            //w,h,x,y,s
            float w = float.Parse(TestContext.DataRow[0].ToString());
            float h = float.Parse(TestContext.DataRow[1].ToString());
            float x_exp = float.Parse(TestContext.DataRow[2].ToString());
            float y_exp = float.Parse(TestContext.DataRow[3].ToString());
            float s_exp = float.Parse(TestContext.DataRow[4].ToString());
            float x_act, y_act, s_act;
            (x_act, y_act, s_act) = methods.CalculateDimensions(w, h);
            Assert.AreEqual(x_exp, x_act);
            Assert.AreEqual(y_exp, y_act);
            Assert.AreEqual(s_exp, s_act);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data14e.csv", "data14e#csv", DataAccessMethod.Sequential), DeploymentItem("data14e.csv"), TestMethod]
        public void KiemThuKhongHopLe()
        {
            Exception expectedException = null;
            try
            {
                PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
                //w,h,x,y,s
                float w = float.Parse(TestContext.DataRow[0].ToString());
                float h = float.Parse(TestContext.DataRow[1].ToString());
                methods.CalculateDimensions(w, h);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
    }
}
