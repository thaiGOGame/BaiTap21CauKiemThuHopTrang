using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai3
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data3.csv", "data3#csv", DataAccessMethod.Sequential), DeploymentItem("data3.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            double mean_act;
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());
            int max_exp = int.Parse(TestContext.DataRow[3].ToString());
            double mean_exp = double.Parse(TestContext.DataRow[4].ToString());
            int max_act = methods.MaxAndMean(a, b, c, out mean_act);
            Assert.AreEqual(max_exp, max_act);
            Assert.AreEqual(mean_exp, mean_act, 0.1);
        }
    }
}
