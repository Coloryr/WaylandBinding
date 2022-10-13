using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WaylandBinding;

public static partial class WaylandUtil
{
    public struct wl_object { }

    public unsafe struct wl_message
    {
        /** Message name */
        public char* name;
        /** Message signature */
        public char* signature;
        /** Object argument interfaces */
        public wl_interface** types;
    }

    public unsafe struct wl_interface
    {
        /** Interface name */
        public char* name;
        /** Interface version */
        public int version;
        /** Number of methods (requests) */
        public int method_count;
        /** Method (request) signatures */
        public wl_message* methods;
        /** Number of events */
        public int event_count;
        /** Event signatures */
        public wl_message* events;
    }

    public unsafe struct wl_list
    {
        /** Previous list element */
        wl_list* prev;
        /** Next list element */
        wl_list* next;
    }

    unsafe struct wl_array
    {
        /** Array size */
        UIntPtr size;
        /** Allocated space */
        UIntPtr alloc;
        /** Array data */
        void* data;
    };

    [LibraryImport("libwayland-client.so.0", EntryPoint = "wl_list_init")]
    public static unsafe partial void WlListInit(wl_list *list);

    [LibraryImport("libwayland-client.so.0", EntryPoint = "wl_list_insert")]
    public static unsafe partial void WlListInsert(wl_list* list, wl_list *elm);

    [LibraryImport("libwayland-client.so.0", EntryPoint = "wl_list_remove")]
    public static unsafe partial void WlListRemove(wl_list* elm);

    [LibraryImport("libwayland-client.so.0", EntryPoint = "wl_list_length")]
    public static unsafe partial int WlListLength(wl_list* list);

    [LibraryImport("libwayland-client.so.0", EntryPoint = "wl_list_empty")]
    public static unsafe partial int WlListEmpty(wl_list* list);

    [LibraryImport("libwayland-client.so.0", EntryPoint = "wl_list_insert_list")]
    public static unsafe partial void WlListInsertList(wl_list* list, wl_list* other);

    public static unsafe void wl_container_of(char* ptr, void * sample, void * member)
    {
        //offsetof
    }

    public static unsafe void wl_list_for_each(uint* pos, void* head, void* member)
    {

    }

    public static unsafe void wl_list_for_each_safe(uint*  pos, void* tmp, void* head, void* member) 
    {
        
    }

    public static unsafe void wl_list_for_each_reverse(uint* pos, void* head, void* member) 
    {
        
    }

    public static unsafe void wl_list_for_each_reverse_safe(uint* pos, void * tmp, void* head, void* member)
    {

    }


    [LibraryImport("libwayland-client.so.0", EntryPoint = "wl_list_insert_list")]
    public static unsafe partial void wl_array_init(wl_list* list, wl_list* other);
}
