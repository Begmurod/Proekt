using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SensorSet
{
    // Самоочищаемый класс, запоминающий форму курсора и восстанавливающий ее при очистке объекта.
    // Используется для операций, длительность которых превышает 2-3 секунды.
    public class HourglassCursor : IDisposable
    {
        private Cursor saveCursor;

        public HourglassCursor()
        {
            saveCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
        }

        public void Dispose()
        {
            Cursor.Current = saveCursor;
        }
    }
}
