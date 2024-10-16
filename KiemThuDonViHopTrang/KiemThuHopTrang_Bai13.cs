using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai13
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data13.csv", "data13#csv", DataAccessMethod.Sequential), DeploymentItem("data13.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            float x1 = float.Parse(TestContext.DataRow[0].ToString());
            float y1 = float.Parse(TestContext.DataRow[1].ToString());
            float x2 = float.Parse(TestContext.DataRow[2].ToString());
            float y2 = float.Parse(TestContext.DataRow[3].ToString());
            float x = float.Parse(TestContext.DataRow[4].ToString());
            float y = float.Parse(TestContext.DataRow[5].ToString());

            bool exp = bool.Parse(TestContext.DataRow[6].ToString());
            bool act = methods.IsPointInRectangle(x1, y1, x2, y2, x, y);
            Assert.AreEqual(exp, act);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data13e.csv", "data13e#csv", DataAccessMethod.Sequential), DeploymentItem("data13e.csv"), TestMethod]
        public void KiemThuKhongHopLe()
        {
            Exception expectedException = null;
            try
            {
                PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
                float x1 = float.Parse(TestContext.DataRow[0].ToString());
                float y1 = float.Parse(TestContext.DataRow[1].ToString());
                float x2 = float.Parse(TestContext.DataRow[2].ToString());
                float y2 = float.Parse(TestContext.DataRow[3].ToString());
                float x = float.Parse(TestContext.DataRow[4].ToString());
                float y = float.Parse(TestContext.DataRow[5].ToString());
                methods.IsPointInRectangle(x1, y1, x2, y2, x, y);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
    }
}
