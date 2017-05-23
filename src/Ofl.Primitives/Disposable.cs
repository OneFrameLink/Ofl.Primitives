using System;

namespace Ofl
{
    public abstract class Disposable : IDisposable
    {
        #region Instance, read-only state.

        #endregion

        #region IDisposable implementation.

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        { }


        ~Disposable() {
            Dispose(false);
        }

        #endregion
    }
}
