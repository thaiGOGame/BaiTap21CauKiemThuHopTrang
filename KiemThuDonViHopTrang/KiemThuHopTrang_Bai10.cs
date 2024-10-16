using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai10
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data10.csv", "data10#csv", DataAccessMethod.Sequential), DeploymentItem("data10.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            // public bool IsValidTriangle(float a, float b, float c)
            float a = float.Parse(TestContext.DataRow[0].ToString());
            float b = float.Parse(TestContext.DataRow[1].ToString());
            float c = float.Parse(TestContext.DataRow[2].ToString());
            bool exp = bool.Parse(TestContext.DataRow[3].ToString());
            bool act = methods.IsValidTriangle(a, b, c);
            Assert.AreEqual(exp, act);
        }
    }
}