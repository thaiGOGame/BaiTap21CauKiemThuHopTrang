using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai21
    {

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data21.csv", "data21#csv", DataAccessMethod.Sequential), DeploymentItem("data21.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            string input = TestContext.DataRow[0].ToString();
            long expected = long.Parse(TestContext.DataRow[1].ToString());
            long act = methods.HexToDec(input);
            Assert.AreEqual(expected, act);

        }
    }
}
