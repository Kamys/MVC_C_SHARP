using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_C_SHARP
{
    abstract class Controller<M, V> where V : View
    {
        private V view;
        private M model;

        public V View
        {
            get
            {
                return view;
            }

            set
            {
                view = value;
            }
        }

        public M Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public Controller(V view, M model)
        {
            this.view = view;
            this.model = model;
        }

        public Controller()
        {
        }

        /// <summary>
        /// Use for show data from model in view.
        /// </summary>
        public void update()
        {
            transferDataInView();
            view.update();
        }

        /// <summary>
        /// Use for transfer data from model in view.
        /// </summary>
        protected abstract void transferDataInView();
    }
}
