using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai5
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data5.csv", "data5#csv", DataAccessMethod.Sequential), DeploymentItem("data5.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            int a = int.Parse(TestContext.DataRow[0].ToString());
            int b = int.Parse(TestContext.DataRow[1].ToString());
            int c = int.Parse(TestContext.DataRow[2].ToString());
            String max_exp = TestContext.DataRow[3].ToString();
            String max_act = methods.Triangle(a, b, c);
            Assert.AreEqual(max_exp, max_act);
        }
    }
}
