using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLibrary.Controll
{
	interface IListor<T>
	{
		void Add(T item);
		void Remove(T item);
		T Get(int item);
		int Count();
		T Find(string strFind);
	}
}
