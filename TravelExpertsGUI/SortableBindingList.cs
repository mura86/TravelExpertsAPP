using System.ComponentModel;
using System.Reflection;
using System.Linq;
using TravelExpertsData;

namespace TravelExpertsGUI
{
    public class SortableBindingList<T> : BindingList<T>, ITypedList
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection;
        private PropertyDescriptor _sortProperty;

        public SortableBindingList(List<object> toList)
        {
            foreach (object item in toList)
            {
                if (item is T typedItem)
                {
                    Add(typedItem);
                }
            }
        }


        protected override bool IsSortedCore => _isSorted;
        protected override ListSortDirection SortDirectionCore => _sortDirection;
        protected override PropertyDescriptor SortPropertyCore => _sortProperty;
        protected override bool SupportsSortingCore => true;

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {
            List<T> items = (List<T>)Items;

            if (property.PropertyType.GetInterface("IComparable") != null)
            {
                items.Sort(new PropertyComparer<T>(property, direction));
            }

            _isSorted = true;
            _sortDirection = direction;
            _sortProperty = property;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        public void ApplySort(DataGridViewColumn column, ListSortDirection direction)
        {
            List<T> items = (List<T>)Items;
            items.Sort((IComparer<T>?)new DataGridViewColumnHeaderSortComparer<DataGridViewRow>(column, direction));

            _isSorted = true;
            _sortDirection = direction;
            _sortProperty = null;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            _isSorted = false;
            _sortDirection = ListSortDirection.Ascending;
            _sortProperty = null;

            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        public class PropertyComparer<TItem> : IComparer<TItem>
        {
            private readonly PropertyDescriptor _property;
            private readonly ListSortDirection _sortDirection;

            public PropertyComparer(PropertyDescriptor property, ListSortDirection sortDirection)
            {
                _property = property;
                _sortDirection = sortDirection;
            }

            public int Compare(TItem x, TItem y)
            {
                object xValue = _property.GetValue(x);
                object yValue = _property.GetValue(y);

                if (_sortDirection == ListSortDirection.Ascending)
                {
                    return CompareAscending(xValue, yValue);
                }
                else
                {
                    return CompareDescending(xValue, yValue);
                }
            }

            private int CompareAscending(object xValue, object yValue)
            {
                int result;

                if (xValue == null && yValue == null)
                {
                    result = 0;
                }
                else if (xValue == null)
                {
                    result = -1;
                }
                else if (yValue == null)
                {
                    result = 1;
                }
                else
                {
                    result = ((IComparable)xValue).CompareTo(yValue);
                }

                return result;
            }

            private int CompareDescending(object xValue, object yValue)
            {
                return -CompareAscending(xValue, yValue);
            }
        }

        public class DataGridViewColumnHeaderSortComparer<TValue> : IComparer<DataGridViewRow>
        {
            private readonly DataGridViewColumn _column;
            private readonly ListSortDirection _sortDirection;

            public DataGridViewColumnHeaderSortComparer(DataGridViewColumn column, ListSortDirection sortDirection)
            {
                _column = column;
                _sortDirection = sortDirection;
            }
            public int Compare(DataGridViewRow x, DataGridViewRow y)
            {
                var value1 = x.Cells[_column.Index].Value;
                var value2 = y.Cells[_column.Index].Value;

                int comparisonResult;

                if (value1 == null && value2 == null)
                {
                    comparisonResult = 0;
                }
                else if (value1 == null)
                {
                    comparisonResult = -1;
                }
                else if (value2 == null)
                {
                    comparisonResult = 1;
                }
                else
                {
                    comparisonResult = Comparer<object>.Default.Compare(value1, value2);
                }

                return _sortDirection == ListSortDirection.Ascending ? comparisonResult : -comparisonResult;
            }
        }
        public void ApplySortAscending(int columnIndex)
        {
            PropertyDescriptorCollection properties = GetItemProperties(null);
            if (columnIndex < 0 || columnIndex >= properties.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(columnIndex), "Invalid column index.");
            }

            PropertyDescriptor propertyDescriptor = properties[columnIndex];
            ListSortDirection sortDirection = ListSortDirection.Ascending;

            ApplySortCore(propertyDescriptor, sortDirection);
        }

        public void ApplySortDescending(int columnIndex)
        {
            PropertyDescriptorCollection properties = GetItemProperties(null);
            if (columnIndex < 0 || columnIndex >= properties.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(columnIndex), "Invalid column index.");
            }

            PropertyDescriptor propertyDescriptor = properties[columnIndex];
            ListSortDirection sortDirection = ListSortDirection.Descending;

            ApplySortCore(propertyDescriptor, sortDirection);
        }


        public PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            if (typeof(T).IsValueType || listAccessors != null && listAccessors.Length > 0)
            {
                return null;
            }

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            return properties;
        }

        public string GetListName(PropertyDescriptor[] listAccessors)
        {
            return typeof(T).Name;
        }


    }
}