using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai12
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data12.csv", "data12#csv", DataAccessMethod.Sequential), DeploymentItem("data12.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            float p1 = float.Parse(TestContext.DataRow[0].ToString());
            float p2 = float.Parse(TestContext.DataRow[1].ToString());
            float p3 = float.Parse(TestContext.DataRow[2].ToString());
            float total = float.Parse(TestContext.DataRow[3].ToString());
            float exp = float.Parse(TestContext.DataRow[4].ToString());
            float act = methods.CalculateElectricityCost(p1, p2, p3, total);
            Assert.AreEqual(exp, act);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data12e.csv", "data12e#csv", DataAccessMethod.Sequential), DeploymentItem("data12e.csv"), TestMethod]
        public void KiemThuKhongHopLe()
        {
            Exception expectedException = null;
            try
            {
                PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
                float p1 = float.Parse(TestContext.DataRow[0].ToString());
                float p2 = float.Parse(TestContext.DataRow[1].ToString());
                float p3 = float.Parse(TestContext.DataRow[2].ToString());
                float total = float.Parse(TestContext.DataRow[3].ToString());
                methods.CalculateElectricityCost(p1, p2, p3, total);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
    }
}
