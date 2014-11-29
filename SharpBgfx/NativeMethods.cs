﻿using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SharpBgfx {
    [SuppressUnmanagedCodeSecurity]
    unsafe static class NativeMethods {
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_update_texture_2d(ushort handle, byte mip, ushort x, ushort y, ushort width, ushort height, MemoryBlock.DataPtr* memory, ushort pitch);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_update_texture_3d (ushort handle, byte mip, ushort x, ushort y, ushort z, ushort width, ushort height, ushort depth, MemoryBlock.DataPtr* memory);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_update_texture_cube (ushort handle, CubeMapFace side, byte mip, ushort x, ushort y, ushort width, ushort height, MemoryBlock.DataPtr* memory, ushort pitch);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool bgfx_check_avail_transient_index_buffer (int num);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool bgfx_check_avail_transient_vertex_buffer (int num, ref VertexLayout.Data decl);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool bgfx_check_avail_instance_data_buffer (int num, ushort stride);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool bgfx_check_avail_transient_buffers (int numVertices, ref VertexLayout.Data decl, int numIndices);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_alloc_transient_index_buffer (ref TransientIndexBuffer.NativeStruct tib, int num);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_alloc_transient_vertex_buffer(ref TransientVertexBuffer.NativeStruct tvb, int num, ref VertexLayout.Data decl);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool bgfx_alloc_transient_buffers (ref TransientVertexBuffer.NativeStruct tvb, ref VertexLayout.Data decl, ushort numVertices, ref TransientIndexBuffer.NativeStruct tib, ushort numIndices);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern InstanceDataBuffer.NativeStruct* bgfx_alloc_instance_data_buffer (int num, ushort stride);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_dispatch (byte id, ushort program, ushort numX, ushort numY, ushort numZ);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_texture (byte stage, ushort sampler, ushort texture, uint flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_texture_from_frame_buffer (byte stage, ushort sampler, ushort frameBuffer, byte attachment, uint flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_image (byte stage, ushort sampler, ushort texture, byte mip, TextureFormat format, ComputeBufferAccess access);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_image_from_frame_buffer (byte stage, ushort sampler, ushort frameBuffer, byte attachment, TextureFormat format, ComputeBufferAccess access);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_frame_buffer (ushort width, ushort height, TextureFormat format, TextureFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_frame_buffer_from_handles (byte count, ushort* handles, [MarshalAs(UnmanagedType.U1)] bool destroyTextures);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_frame_buffer_from_nwh (IntPtr nwh, ushort width, ushort height, TextureFormat depthFormat);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_frame_buffer (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_frame_buffer (byte id, ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_program (ushort vsh, ushort fsh, [MarshalAs(UnmanagedType.U1)] bool destroyShaders);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_program (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern Capabilities.Caps* bgfx_get_caps ();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_vertex_decl_begin (ref VertexLayout.Data decl, RendererBackend backend);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_vertex_decl_add (ref VertexLayout.Data decl, VertexAttributeUsage attribute, byte count, VertexAttributeType type, [MarshalAs(UnmanagedType.U1)] bool normalized, [MarshalAs(UnmanagedType.U1)] bool asInt);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_vertex_decl_skip (ref VertexLayout.Data decl, byte count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_vertex_decl_end (ref VertexLayout.Data decl);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_vertex_buffer (MemoryBlock.DataPtr* memory, ref VertexLayout.Data decl);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_vertex_buffer (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_uniform ([MarshalAs(UnmanagedType.LPStr)] string name, UniformType type, ushort arraySize);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_uniform (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_texture (MemoryBlock.DataPtr* mem, TextureFlags flags, byte skip, out Texture.TextureInfo info);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_texture_2d (ushort width, ushort _height, byte numMips, TextureFormat format, TextureFlags flags, MemoryBlock.DataPtr* mem);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_texture_3d (ushort width, ushort _height, ushort _depth, byte numMips, TextureFormat format, TextureFlags flags, MemoryBlock.DataPtr* mem);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_texture_cube (ushort size, byte numMips, TextureFormat format, TextureFlags flags, MemoryBlock.DataPtr* mem);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_texture (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_calc_texture_size (ref Texture.TextureInfo info, ushort width, ushort height, ushort depth, byte mipCount, TextureFormat format);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_shader (MemoryBlock.DataPtr* memory);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_get_shader_uniforms (ushort handle, Uniform[] uniforms, ushort max);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_shader (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern MemoryBlock.DataPtr* bgfx_alloc (int size);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern MemoryBlock.DataPtr* bgfx_copy (IntPtr data, int size);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_index_buffer (MemoryBlock.DataPtr* memory);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_index_buffer (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_dynamic_index_buffer (int indexCount);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_dynamic_index_buffer_mem (MemoryBlock.DataPtr* memory);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_update_dynamic_index_buffer (ushort handle, MemoryBlock.DataPtr* memory);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_dynamic_index_buffer (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_dynamic_vertex_buffer (ushort indexCount, ref VertexLayout.Data decl);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_create_dynamic_vertex_buffer_mem (MemoryBlock.DataPtr* memory, ref VertexLayout.Data decl);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_update_dynamic_vertex_buffer (ushort handle, MemoryBlock.DataPtr* memory);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_destroy_dynamic_vertex_buffer (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_image_swizzle_bgra8 (int width, int height, int pitch, IntPtr src, IntPtr dst);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_image_rgba8_downsample_2x2 (int width, int height, int pitch, IntPtr src, IntPtr dst);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_win_set_hwnd (IntPtr hwnd);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern RendererBackend bgfx_get_renderer_type ();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_shutdown ();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_reset (int width, int height, ResetFlags flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int bgfx_frame ();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_debug (DebugFeatures flags);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_marker ([MarshalAs(UnmanagedType.LPStr)] string marker);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_dbg_text_clear (byte color, [MarshalAs(UnmanagedType.U1)] bool smallText);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int bgfx_set_transform (float* matrix, ushort count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_stencil (uint frontFace, uint backFace);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int bgfx_submit (byte id, int depth);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_discard ();

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_name (byte id, [MarshalAs(UnmanagedType.LPStr)] string name);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_rect (byte id, ushort x, ushort y, ushort width, ushort height);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_scissor (byte id, ushort x, ushort y, ushort width, ushort height);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_clear (byte id, ClearTargets flags, int rgba, float depth, byte stencil);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_clear_mrt (byte id, ClearTargets flags, float depth, byte stencil, byte rt0, byte rt1, byte rt2, byte rt3, byte rt4, byte rt5, byte rt6, byte rt7);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_clear_color (byte index, float* color);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_seq (byte id, [MarshalAs(UnmanagedType.U1)] bool enabled);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_view_transform (byte id, float* view, float* proj);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_save_screen_shot ([MarshalAs(UnmanagedType.LPStr)] string filePath);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_state (ulong state, int rgba);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_vertex_pack (float* input, [MarshalAs(UnmanagedType.U1)] bool inputNormalized, VertexAttributeUsage attribute, ref VertexLayout.Data decl, IntPtr data, int index);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_vertex_unpack (float* output, VertexAttributeUsage attribute, ref VertexLayout.Data decl, IntPtr data, int index);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_vertex_convert (ref VertexLayout.Data destDecl, IntPtr destData, ref VertexLayout.Data srcDecl, IntPtr srcData, int num);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_weld_vertices (ushort* output, ref VertexLayout.Data decl, IntPtr data, ushort num, float epsilon);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern byte bgfx_get_supported_renderers (RendererBackend[] backends);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern sbyte* bgfx_get_renderer_name (RendererBackend backend);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_init (RendererBackend backend, IntPtr callbacks, IntPtr allocator);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_dbg_text_printf (ushort x, ushort y, byte color, [MarshalAs(UnmanagedType.LPStr)] string format, [MarshalAs(UnmanagedType.LPStr)] string args);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_program (ushort handle);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_index_buffer (ushort handle, int firstIndex, int count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_dynamic_index_buffer (ushort handle, int firstIndex, int count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_vertex_buffer (ushort handle, int startVertex, int count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_dynamic_vertex_buffer (ushort handle, int startVertex, int count);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_uniform (ushort handle, void* value, ushort arraySize);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_transform_cached (int cache, ushort num);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ushort bgfx_set_scissor (ushort x, ushort y, ushort width, ushort height);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_scissor_cached (ushort cache);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_transient_vertex_buffer (ref TransientVertexBuffer.NativeStruct tvb, int startVertex, int numVertices);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_transient_index_buffer (ref TransientIndexBuffer.NativeStruct tib, int startIndex, int numIndices);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern void bgfx_set_instance_data_buffer (InstanceDataBuffer.NativeStruct* idb, ushort num);

#if DEBUG
        const string DllName = "bgfx_debug.dll";
#else
        const string DllName = "bgfx.dll";
#endif
    }
}