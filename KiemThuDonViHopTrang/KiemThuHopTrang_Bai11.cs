using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai11
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data11.csv", "data11#csv", DataAccessMethod.Sequential), DeploymentItem("data11.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            float w = float.Parse(TestContext.DataRow[0].ToString());
            float h = float.Parse(TestContext.DataRow[1].ToString());
            float ww = float.Parse(TestContext.DataRow[2].ToString());
            float wh = float.Parse(TestContext.DataRow[3].ToString());
            float x_exp = float.Parse(TestContext.DataRow[4].ToString());
            float y_exp = float.Parse(TestContext.DataRow[5].ToString());
            float x_act, y_act;
            (x_act, y_act) = methods.CalculatePositionImageInWindow(w,h,ww,wh);
            
            Assert.AreEqual(x_act, x_exp);
            Assert.AreEqual(y_act, y_exp);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data11e.csv", "data11e#csv", DataAccessMethod.Sequential), DeploymentItem("data11e.csv"), TestMethod]
        public void KiemThuKhongHopLe()
        {
            Exception expectedException = null;
            try
            {
                PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
                float w = float.Parse(TestContext.DataRow[0].ToString());
                float h = float.Parse(TestContext.DataRow[1].ToString());
                float ww = float.Parse(TestContext.DataRow[2].ToString());
                float wh = float.Parse(TestContext.DataRow[3].ToString());
                methods.CalculatePositionImageInWindow(w, h, ww, wh);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
    }
}
