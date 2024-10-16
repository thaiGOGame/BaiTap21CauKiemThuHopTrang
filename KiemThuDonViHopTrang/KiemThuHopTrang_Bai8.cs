using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThuVienKiemThuHopTrang;
using System;

namespace KiemThuDonViHopTrang
{
    [TestClass]
    public class KiemThuHopTrang_Bai8
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
     "|DataDirectory|\\data8.csv", "data8#csv",
 DataAccessMethod.Sequential),
 DeploymentItem("data8.csv"), TestMethod]
        public void KiemThuHopLe()
        {
            PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
            float a = float.Parse(TestContext.DataRow[0].ToString());
            float b = float.Parse(TestContext.DataRow[1].ToString());
            float c = float.Parse(TestContext.DataRow[2].ToString());
            float x1_exp = float.Parse(TestContext.DataRow[3].ToString());
            float x2_exp = float.Parse(TestContext.DataRow[4].ToString());
            (float? x1_act, float? x2_act) = methods.SolveQuadraticEquation(a, b, c);
            if (x1_act.HasValue)
                x1_act = (float)Math.Round(x1_act.Value, 2);
            x1_exp = (float)Math.Round(x1_exp, 2);

            if (x2_act.HasValue)
                x2_act = (float)Math.Round(x2_act.Value, 2);
            x2_exp = (float)Math.Round(x2_exp, 2);
            Assert.AreEqual(x1_exp, x1_act);
            Assert.AreEqual(x2_exp, x2_act);
        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data9e.csv", "data9e#csv", DataAccessMethod.Sequential), DeploymentItem("data8e.csv"), TestMethod]
        public void KiemThuKhongHopLe()
        {
            Exception expectedException = null;
            try
            {
                PhuongThucKiemThuHopTrang methods = new PhuongThucKiemThuHopTrang();
                float a = float.Parse(TestContext.DataRow[0].ToString());
                float b = float.Parse(TestContext.DataRow[1].ToString());
                float c = float.Parse(TestContext.DataRow[2].ToString());
                float x1_exp = float.Parse(TestContext.DataRow[3].ToString());
                float x2_exp = float.Parse(TestContext.DataRow[4].ToString());
                methods.SolveQuadraticEquation(a, b, c);
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }
            Assert.IsNotNull(expectedException);
        }
    }
}