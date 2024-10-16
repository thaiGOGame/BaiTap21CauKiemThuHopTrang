using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ThuVienKiemThuHopTrang;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai9
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data9.csv", "data9#csv", DataAccessMethod.Sequential), DeploymentItem("data9.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            //public float CheckValueInRangeAToB(float a, float b, float x)
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            float a = float.Parse(TestContext.DataRow[0].ToString());
            float b = float.Parse(TestContext.DataRow[1].ToString());
            float x = float.Parse(TestContext.DataRow[2].ToString());
            float exp = float.Parse(TestContext.DataRow[3].ToString());
            float act = methods.CheckValueInRangeAToB(a,b,x);
            Assert.AreEqual(exp, act);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data9e.csv", "data9e#csv", DataAccessMethod.Sequential), DeploymentItem("data9e.csv"), TestMethod]
        public void KiemThuKhongHopLe()
        {
            Exception expectedException = null;
            try
            {
                PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
                float a = float.Parse(TestContext.DataRow[0].ToString());
                float b = float.Parse(TestContext.DataRow[1].ToString());
                float x = float.Parse(TestContext.DataRow[2].ToString());
                float exp = float.Parse(TestContext.DataRow[3].ToString());
                methods.CheckValueInRangeAToB(a, b, x);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
    }
}
