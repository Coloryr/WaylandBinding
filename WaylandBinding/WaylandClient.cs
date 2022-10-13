using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WaylandBinding;

public static partial class WaylandClient
{
    public struct wl_proxy { }

    public struct wl_display { }

    public struct wl_event_queue { }

    [LibraryImport("libwayland-client.so.0", EntryPoint = "wl_event_queue_destroy")]
    public static unsafe partial void WlEventQueueDestroy(wl_event_queue* queue);

    [LibraryImport("libwayland-client.so.0", EntryPoint = "wl_proxy_marshal_flags")]
    public static unsafe partial wl_proxy* WlProxyMarshalFlags(wl_proxy *proxy, uint opcode,
               WaylandUtil.wl_interface* interface_,
		       uint version,
               uint flags, ...);

    [LibraryImport("libwayland-client.so.0", EntryPoint = "wl_proxy_marshal_flags")]
    public static unsafe partial wl_proxy* WlProxyMarshalFlags(wl_event_queue* queue);
}
