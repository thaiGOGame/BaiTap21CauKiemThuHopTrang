using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai16
    {

        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data16.csv", "data16#csv", DataAccessMethod.Sequential), DeploymentItem("data16.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            string input = TestContext.DataRow[0].ToString();
            bool expected = bool.Parse(TestContext.DataRow[1].ToString());
            bool act = methods.PasswordCheck(input);
            Assert.AreEqual(expected,act);

        }
    }
}
