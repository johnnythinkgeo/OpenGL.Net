
// Copyright (C) 2015-2017 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

#pragma warning disable 649, 1572, 1573

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace OpenGL
{
	public partial class Gl
	{
		/// <summary>
		/// Gl.Clear: Indicates the depth buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint DEPTH_BUFFER_BIT = 0x00000100;

		/// <summary>
		/// Gl.Clear: Indicates the stencil buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint STENCIL_BUFFER_BIT = 0x00000400;

		/// <summary>
		/// Gl.Clear: Indicates the buffers currently enabled for color writing.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[Log(BitmaskName = "GL")]
		public const uint COLOR_BUFFER_BIT = 0x00004000;

		/// <summary>
		/// Value of GL_FALSE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int FALSE = 0;

		/// <summary>
		/// Value of GL_TRUE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int TRUE = 1;

		/// <summary>
		/// Gl.Begin: Treats each vertex as a single point. Vertex n defines point n. N points are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int POINTS = 0x0000;

		/// <summary>
		/// Gl.Begin: Treats each pair of vertices as an independent line segment. Vertices 2⁢n-1 and 2⁢n define line n. N2 lines 
		/// are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int LINES = 0x0001;

		/// <summary>
		/// Gl.Begin: Draws a connected group of line segments from the first vertex to the last, then back to the first. Vertices n 
		/// and n+1 define line n. The last line, however, is defined by vertices N and 1. N lines are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int LINE_LOOP = 0x0002;

		/// <summary>
		/// Gl.Begin: Draws a connected group of line segments from the first vertex to the last. Vertices n and n+1 define line n. 
		/// N-1 lines are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int LINE_STRIP = 0x0003;

		/// <summary>
		/// Gl.Begin: Treats each triplet of vertices as an independent triangle. Vertices 3⁢n-2, 3⁢n-1, and 3⁢n define triangle n. 
		/// N3 triangles are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int TRIANGLES = 0x0004;

		/// <summary>
		/// Gl.Begin: Draws a connected group of triangles. One triangle is defined for each vertex presented after the first two 
		/// vertices. For odd n, vertices n, n+1, and n+2 define triangle n. For even n, vertices n+1, n, and n+2 define triangle n. 
		/// N-2 triangles are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int TRIANGLE_STRIP = 0x0005;

		/// <summary>
		/// Gl.Begin: Draws a connected group of triangles. One triangle is defined for each vertex presented after the first two 
		/// vertices. Vertices 1, n+1, and n+2 define triangle n. N-2 triangles are drawn.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int TRIANGLE_FAN = 0x0006;

		/// <summary>
		/// Gl.Begin: Treats each group of four vertices as an independent quadrilateral. Vertices 4⁢n-3, 4⁢n-2, 4⁢n-1, and 4⁢n 
		/// define quadrilateral n. N4 quadrilaterals are drawn.
		/// </summary>
		[AliasOf("GL_QUADS_EXT")]
		[AliasOf("GL_QUADS_OES")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int QUADS = 0x0007;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: Never passes.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: Always fails.
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: Always fails.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int NEVER = 0x0200;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: Passes if the incoming depth value is less than the stored depth value.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: Passes if ( ref &amp; mask ) &lt; ( stencil &amp; mask ).
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) &lt; ( stencil &amp; mask ).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int LESS = 0x0201;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: Passes if the incoming depth value is equal to the stored depth value.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: Passes if ( ref &amp; mask ) = ( stencil &amp; mask ).
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) = ( stencil &amp; mask ).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int EQUAL = 0x0202;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: Passes if the incoming depth value is less than or equal to the stored depth value.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: Passes if ( ref &amp; mask ) &lt;= ( stencil &amp; mask ).
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) &lt;= ( stencil &amp; mask ).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int LEQUAL = 0x0203;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: Passes if the incoming depth value is greater than the stored depth value.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: Passes if ( ref &amp; mask ) &gt; ( stencil &amp; mask ).
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) &gt; ( stencil &amp; mask ).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int GREATER = 0x0204;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: Passes if the incoming depth value is not equal to the stored depth value.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: Passes if ( ref &amp; mask ) != ( stencil &amp; mask ).
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) != ( stencil &amp; mask ).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int NOTEQUAL = 0x0205;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: Passes if the incoming depth value is greater than or equal to the stored depth value.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: Passes if ( ref &amp; mask ) &gt;= ( stencil &amp; mask ).
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: Passes if ( ref &amp; mask ) &gt;= ( stencil &amp; mask ).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int GEQUAL = 0x0206;

		/// <summary>
		/// <para>
		/// Gl.DepthFunc: Always passes.
		/// </para>
		/// <para>
		/// Gl.StencilFunc: Always passes.
		/// </para>
		/// <para>
		/// Gl.StencilFuncSeparate: Always passes.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int ALWAYS = 0x0207;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: Sets the stencil buffer value to 0.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: Sets the stencil buffer value to 0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public const int ZERO = 0;

		/// <summary>
		/// Value of GL_ONE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public const int ONE = 1;

		/// <summary>
		/// Value of GL_SRC_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public const int SRC_COLOR = 0x0300;

		/// <summary>
		/// Value of GL_ONE_MINUS_SRC_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public const int ONE_MINUS_SRC_COLOR = 0x0301;

		/// <summary>
		/// Value of GL_SRC_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public const int SRC_ALPHA = 0x0302;

		/// <summary>
		/// Value of GL_ONE_MINUS_SRC_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public const int ONE_MINUS_SRC_ALPHA = 0x0303;

		/// <summary>
		/// Value of GL_DST_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public const int DST_ALPHA = 0x0304;

		/// <summary>
		/// Value of GL_ONE_MINUS_DST_ALPHA symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public const int ONE_MINUS_DST_ALPHA = 0x0305;

		/// <summary>
		/// Value of GL_DST_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public const int DST_COLOR = 0x0306;

		/// <summary>
		/// Value of GL_ONE_MINUS_DST_COLOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public const int ONE_MINUS_DST_COLOR = 0x0307;

		/// <summary>
		/// Value of GL_SRC_ALPHA_SATURATE symbol.
		/// </summary>
		[AliasOf("GL_SRC_ALPHA_SATURATE_EXT")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_EXT_blend_func_extended", Api = "gles2")]
		public const int SRC_ALPHA_SATURATE = 0x0308;

		/// <summary>
		/// <para>
		/// Gl.DrawBuffer: No color buffers are written.
		/// </para>
		/// <para>
		/// Gl.DrawBuffers: The fragment shader output value is not written into any color buffer.
		/// </para>
		/// </summary>
		[AliasOf("GL_NONE_OES")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_KHR_context_flush_control", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RequiredByFeature("GL_OES_framebuffer_object", Api = "gles1")]
		public const int NONE = 0;

		/// <summary>
		/// <para>
		/// Gl.DrawBuffer: Only the front left color buffer is written.
		/// </para>
		/// <para>
		/// Gl.DrawBuffers: The fragment shader output value is written into the front left color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int FRONT_LEFT = 0x0400;

		/// <summary>
		/// <para>
		/// Gl.DrawBuffer: Only the front right color buffer is written.
		/// </para>
		/// <para>
		/// Gl.DrawBuffers: The fragment shader output value is written into the front right color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int FRONT_RIGHT = 0x0401;

		/// <summary>
		/// <para>
		/// Gl.DrawBuffer: Only the back left color buffer is written.
		/// </para>
		/// <para>
		/// Gl.DrawBuffers: The fragment shader output value is written into the back left color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int BACK_LEFT = 0x0402;

		/// <summary>
		/// <para>
		/// Gl.DrawBuffer: Only the back right color buffer is written.
		/// </para>
		/// <para>
		/// Gl.DrawBuffers: The fragment shader output value is written into the back right color buffer.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int BACK_RIGHT = 0x0403;

		/// <summary>
		/// Gl.DrawBuffer: Only the front left and front right color buffers are written. If there is no front right color buffer, 
		/// only the front left color buffer is written.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int FRONT = 0x0404;

		/// <summary>
		/// Gl.DrawBuffer: Only the back left and back right color buffers are written. If there is no back right color buffer, only 
		/// the back left color buffer is written.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_ES3_1_compatibility", Api = "gl|glcore")]
		public const int BACK = 0x0405;

		/// <summary>
		/// Gl.DrawBuffer: Only the front left and back left color buffers are written. If there is no back left color buffer, only 
		/// the front left color buffer is written.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int LEFT = 0x0406;

		/// <summary>
		/// Gl.DrawBuffer: Only the front right and back right color buffers are written. If there is no back right color buffer, 
		/// only the front right color buffer is written.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int RIGHT = 0x0407;

		/// <summary>
		/// Gl.DrawBuffer: All the front and back color buffers (front left, front right, back left, back right) are written. If 
		/// there are no back color buffers, only the front left and front right color buffers are written. If there are no right 
		/// color buffers, only the front left and back left color buffers are written. If there are no right or back color buffers, 
		/// only the front left color buffer is written.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int FRONT_AND_BACK = 0x0408;

		/// <summary>
		/// <para>
		/// Gl.GetError: No error has been recorded. The value of this symbolic constant is guaranteed to be 0.
		/// </para>
		/// <para>
		/// Gl.GetGraphicsResetStatus: Indicates that the GL context has not been in a reset state since the last call.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_5")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_robustness", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_robustness", Api = "gles1|gles2")]
		[RequiredByFeature("GL_KHR_robustness", Api = "gl|glcore|gles2")]
		public const int NO_ERROR = 0;

		/// <summary>
		/// Gl.GetError: An unacceptable value is specified for an enumerated argument. The offending command is ignored and has no 
		/// other side effect than to set the error flag.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int INVALID_ENUM = 0x0500;

		/// <summary>
		/// Gl.GetError: A numeric argument is out of range. The offending command is ignored and has no other side effect than to 
		/// set the error flag.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int INVALID_VALUE = 0x0501;

		/// <summary>
		/// Gl.GetError: The specified operation is not allowed in the current state. The offending command is ignored and has no 
		/// other side effect than to set the error flag.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int INVALID_OPERATION = 0x0502;

		/// <summary>
		/// Gl.GetError: There is not enough memory left to execute the command. The state of the GL is undefined, except for the 
		/// state of the error flags, after this error is recorded.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int OUT_OF_MEMORY = 0x0505;

		/// <summary>
		/// Value of GL_CW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int CW = 0x0900;

		/// <summary>
		/// Value of GL_CCW symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_tessellation_shader", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_tessellation_shader", Api = "gles2")]
		[RequiredByFeature("GL_OES_tessellation_shader", Api = "gles2")]
		public const int CCW = 0x0901;

		/// <summary>
		/// Gl.Get: data returns one value, the point size as specified by Gl.PointSize. The initial value is 1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int POINT_SIZE = 0x0B11;

		/// <summary>
		/// Gl.Get: data returns two values: the smallest and largest supported sizes for antialiased points. The smallest size must 
		/// be at most 1, and the largest size must be at least 1. See Gl.PointSize.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int POINT_SIZE_RANGE = 0x0B12;

		/// <summary>
		/// Gl.Get: data returns one value, the size difference between adjacent supported sizes for antialiased points. See 
		/// Gl.PointSize.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int POINT_SIZE_GRANULARITY = 0x0B13;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether antialiasing of lines is enabled. The initial value is 
		/// Gl.FALSE. See Gl.LineWidth.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int LINE_SMOOTH = 0x0B20;

		/// <summary>
		/// Gl.Get: data returns one value, the line width as specified with Gl.LineWidth. The initial value is 1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int LINE_WIDTH = 0x0B21;

		/// <summary>
		/// Gl.Get: params returns two values: the smallest and largest supported widths for antialiased lines. See Gl.LineWidth.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int LINE_WIDTH_RANGE = 0x0B22;

		/// <summary>
		/// Gl.Get: params returns one value, the width difference between adjacent supported widths for antialiased lines. See 
		/// Gl.LineWidth.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int LINE_WIDTH_GRANULARITY = 0x0B23;

		/// <summary>
		/// Gl.Get: params returns two values: symbolic constants indicating whether front-facing and back-facing polygons are 
		/// rasterized as points, lines, or filled polygons. The initial value is Gl.FILL. See Gl.PolygonMode.
		/// </summary>
		[AliasOf("GL_POLYGON_MODE_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		public const int POLYGON_MODE = 0x0B40;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether antialiasing of polygons is enabled. The initial value is 
		/// Gl.FALSE. See Gl.PolygonMode.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int POLYGON_SMOOTH = 0x0B41;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether polygon culling is enabled. The initial value is 
		/// Gl.FALSE. See Gl.CullFace.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int CULL_FACE = 0x0B44;

		/// <summary>
		/// Gl.Get: data returns a single value indicating the mode of polygon culling. The initial value is Gl.BACK. See 
		/// Gl.CullFace.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int CULL_FACE_MODE = 0x0B45;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating whether clockwise or counterclockwise polygon winding 
		/// is treated as front-facing. The initial value is Gl.CCW. See Gl.FrontFace.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int FRONT_FACE = 0x0B46;

		/// <summary>
		/// Gl.Get: data returns two values: the near and far mapping limits for the depth buffer. Integer values, if requested, are 
		/// linearly mapped from the internal floating-point representation such that 1.0 returns the most positive representable 
		/// integer value, and -1.0 returns the most negative representable integer value. The initial value is (0, 1). See 
		/// Gl.DepthRange.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public const int DEPTH_RANGE = 0x0B70;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether depth testing of fragments is enabled. The initial value 
		/// is Gl.FALSE. See Gl.DepthFunc and Gl.DepthRange.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int DEPTH_TEST = 0x0B71;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating if the depth buffer is enabled for writing. The initial value is 
		/// Gl.TRUE. See Gl.DepthMask.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int DEPTH_WRITEMASK = 0x0B72;

		/// <summary>
		/// Gl.Get: data returns one value, the value that is used to clear the depth buffer. Integer values, if requested, are 
		/// linearly mapped from the internal floating-point representation such that 1.0 returns the most positive representable 
		/// integer value, and -1.0 returns the most negative representable integer value. The initial value is 1. See 
		/// Gl.ClearDepth.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int DEPTH_CLEAR_VALUE = 0x0B73;

		/// <summary>
		/// Gl.Get: data returns one value, the symbolic constant that indicates the depth comparison function. The initial value is 
		/// Gl.LESS. See Gl.DepthFunc.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int DEPTH_FUNC = 0x0B74;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether stencil testing of fragments is enabled. The initial 
		/// value is Gl.FALSE. See Gl.StencilFunc and Gl.StencilOp.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int STENCIL_TEST = 0x0B90;

		/// <summary>
		/// Gl.Get: data returns one value, the index to which the stencil bitplanes are cleared. The initial value is 0. See 
		/// Gl.ClearStencil.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int STENCIL_CLEAR_VALUE = 0x0B91;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating what function is used to compare the stencil reference 
		/// value with the stencil buffer value. The initial value is Gl.ALWAYS. See Gl.StencilFunc. This stencil state only affects 
		/// non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See Gl.StencilFuncSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int STENCIL_FUNC = 0x0B92;

		/// <summary>
		/// Gl.Get: data returns one value, the mask that is used to mask both the stencil reference value and the stencil buffer 
		/// value before they are compared. The initial value is all 1's. See Gl.StencilFunc. This stencil state only affects 
		/// non-polygons and front-facing polygons. Back-facing polygons use separate stencil state. See Gl.StencilFuncSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int STENCIL_VALUE_MASK = 0x0B93;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating what action is taken when the stencil test fails. The 
		/// initial value is Gl.KEEP. See Gl.StencilOp. This stencil state only affects non-polygons and front-facing polygons. 
		/// Back-facing polygons use separate stencil state. See Gl.StencilOpSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int STENCIL_FAIL = 0x0B94;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating what action is taken when the stencil test passes, but 
		/// the depth test fails. The initial value is Gl.KEEP. See Gl.StencilOp. This stencil state only affects non-polygons and 
		/// front-facing polygons. Back-facing polygons use separate stencil state. See Gl.StencilOpSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int STENCIL_PASS_DEPTH_FAIL = 0x0B95;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating what action is taken when the stencil test passes and the 
		/// depth test passes. The initial value is Gl.KEEP. See Gl.StencilOp. This stencil state only affects non-polygons and 
		/// front-facing polygons. Back-facing polygons use separate stencil state. See Gl.StencilOpSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int STENCIL_PASS_DEPTH_PASS = 0x0B96;

		/// <summary>
		/// Gl.Get: data returns one value, the reference value that is compared with the contents of the stencil buffer. The 
		/// initial value is 0. See Gl.StencilFunc. This stencil state only affects non-polygons and front-facing polygons. 
		/// Back-facing polygons use separate stencil state. See Gl.StencilFuncSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int STENCIL_REF = 0x0B97;

		/// <summary>
		/// Gl.Get: data returns one value, the mask that controls writing of the stencil bitplanes. The initial value is all 1's. 
		/// See Gl.StencilMask. This stencil state only affects non-polygons and front-facing polygons. Back-facing polygons use 
		/// separate stencil state. See Gl.StencilMaskSeparate.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int STENCIL_WRITEMASK = 0x0B98;

		/// <summary>
		/// Gl.Get: When used with non-indexed variants of glGet (such as glGetIntegerv), data returns four values: the x and y 
		/// window coordinates of the viewport, followed by its width and height. Initially the x and y window coordinates are both 
		/// set to 0, and the width and height are set to the width and height of the window into which the GL will do its 
		/// rendering. See Gl.Viewport. When used with indexed variants of glGet (such as glGetIntegeri_v), data returns four 
		/// values: the x and y window coordinates of the indexed viewport, followed by its width and height. Initially the x and y 
		/// window coordinates are both set to 0, and the width and height are set to the width and height of the window into which 
		/// the GL will do its rendering. See glViewportIndexedf.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public const int VIEWPORT = 0x0BA2;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether dithering of fragment colors and indices is enabled. The 
		/// initial value is Gl.TRUE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int DITHER = 0x0BD0;

		/// <summary>
		/// Value of GL_BLEND_DST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int BLEND_DST = 0x0BE0;

		/// <summary>
		/// Value of GL_BLEND_SRC symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int BLEND_SRC = 0x0BE1;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether blending is enabled. The initial value is Gl.FALSE. See 
		/// Gl.BlendFunc.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public const int BLEND = 0x0BE2;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating the selected logic operation mode. The initial value is 
		/// Gl.COPY. See Gl.LogicOp.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int LOGIC_OP_MODE = 0x0BF0;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating which buffers are being drawn to. See Gl.DrawBuffer. The 
		/// initial value is Gl.BACK if there are back buffers, otherwise it is Gl.FRONT.
		/// </summary>
		[AliasOf("GL_DRAW_BUFFER_EXT")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		public const int DRAW_BUFFER = 0x0C01;

		/// <summary>
		/// Gl.Get: data returns one value, a symbolic constant indicating which color buffer is selected for reading. The initial 
		/// value is Gl.BACK if there is a back buffer, otherwise it is Gl.FRONT. See Gl.ReadPixels.
		/// </summary>
		[AliasOf("GL_READ_BUFFER_EXT")]
		[AliasOf("GL_READ_BUFFER_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_multiview_draw_buffers", Api = "gles2")]
		[RequiredByFeature("GL_NV_read_buffer", Api = "gles2")]
		public const int READ_BUFFER = 0x0C02;

		/// <summary>
		/// Gl.Get: data returns four values: the x and y window coordinates of the scissor box, followed by its width and height. 
		/// Initially the x and y window coordinates are both 0 and the width and height are set to the size of the window. See 
		/// Gl.Scissor.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public const int SCISSOR_BOX = 0x0C10;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether scissoring is enabled. The initial value is Gl.FALSE. See 
		/// Gl.Scissor.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_viewport_array", Api = "gl|glcore")]
		[RequiredByFeature("GL_NV_viewport_array", Api = "gles2")]
		[RequiredByFeature("GL_OES_viewport_array", Api = "gles2")]
		public const int SCISSOR_TEST = 0x0C11;

		/// <summary>
		/// Gl.Get: data returns four values: the red, green, blue, and alpha values used to clear the color buffers. Integer 
		/// values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most 
		/// positive representable integer value, and -1.0 returns the most negative representable integer value. The initial value 
		/// is (0, 0, 0, 0). See Gl.ClearColor.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int COLOR_CLEAR_VALUE = 0x0C22;

		/// <summary>
		/// Gl.Get: data returns four boolean values: the red, green, blue, and alpha write enables for the color buffers. The 
		/// initial value is (Gl.TRUE, Gl.TRUE, Gl.TRUE, Gl.TRUE). See Gl.ColorMask.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_draw_buffers_indexed", Api = "gles2")]
		[RequiredByFeature("GL_OES_draw_buffers_indexed", Api = "gles2")]
		public const int COLOR_WRITEMASK = 0x0C23;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether double buffering is supported.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: param returns a boolean value indicating whether double buffering is supported for the 
		/// framebuffer object.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int DOUBLEBUFFER = 0x0C32;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns a single boolean value indicating whether stereo buffers (left and right) are supported.
		/// </para>
		/// <para>
		/// Gl.GetFramebufferParameter: param returns a boolean value indicating whether stereo buffers (left and right) are 
		/// supported for the framebuffer object.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int STEREO = 0x0C33;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, a symbolic constant indicating the mode of the line antialiasing hint. The initial value 
		/// is Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// Gl.Hint: Indicates the sampling quality of antialiased lines. If a larger filter function is applied, hinting Gl.NICEST 
		/// can result in more pixel fragments being generated during rasterization.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int LINE_SMOOTH_HINT = 0x0C52;

		/// <summary>
		/// <para>
		/// Gl.Get: data returns one value, a symbolic constant indicating the mode of the polygon antialiasing hint. The initial 
		/// value is Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// Gl.Hint: Indicates the sampling quality of antialiased polygons. Hinting Gl.NICEST can result in more pixel fragments 
		/// being generated during rasterization, if a larger filter function is applied.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int POLYGON_SMOOTH_HINT = 0x0C53;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether the bytes of two-byte and four-byte pixel indices and 
		/// components are swapped after being read from memory. The initial value is Gl.FALSE. See Gl.PixelStore.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int UNPACK_SWAP_BYTES = 0x0CF0;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether single-bit pixels being read from memory are read first 
		/// from the least significant bit of each unsigned byte. The initial value is Gl.FALSE. See Gl.PixelStore.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int UNPACK_LSB_FIRST = 0x0CF1;

		/// <summary>
		/// Gl.Get: data returns one value, the row length used for reading pixel data from memory. The initial value is 0. See 
		/// Gl.PixelStore.
		/// </summary>
		[AliasOf("GL_UNPACK_ROW_LENGTH_EXT")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_unpack_subimage", Api = "gles2")]
		public const int UNPACK_ROW_LENGTH = 0x0CF2;

		/// <summary>
		/// Gl.Get: data returns one value, the number of rows of pixel locations skipped before the first pixel is read from 
		/// memory. The initial value is 0. See Gl.PixelStore.
		/// </summary>
		[AliasOf("GL_UNPACK_SKIP_ROWS_EXT")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_unpack_subimage", Api = "gles2")]
		public const int UNPACK_SKIP_ROWS = 0x0CF3;

		/// <summary>
		/// Gl.Get: data returns one value, the number of pixel locations skipped before the first pixel is read from memory. The 
		/// initial value is 0. See Gl.PixelStore.
		/// </summary>
		[AliasOf("GL_UNPACK_SKIP_PIXELS_EXT")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_unpack_subimage", Api = "gles2")]
		public const int UNPACK_SKIP_PIXELS = 0x0CF4;

		/// <summary>
		/// Gl.Get: data returns one value, the byte alignment used for reading pixel data from memory. The initial value is 4. See 
		/// Gl.PixelStore.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int UNPACK_ALIGNMENT = 0x0CF5;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether the bytes of two-byte and four-byte pixel indices and 
		/// components are swapped before being written to memory. The initial value is Gl.FALSE. See Gl.PixelStore.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int PACK_SWAP_BYTES = 0x0D00;

		/// <summary>
		/// Gl.Get: data returns a single boolean value indicating whether single-bit pixels being written to memory are written 
		/// first to the least significant bit of each unsigned byte. The initial value is Gl.FALSE. See Gl.PixelStore.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		public const int PACK_LSB_FIRST = 0x0D01;

		/// <summary>
		/// Gl.Get: data returns one value, the row length used for writing pixel data to memory. The initial value is 0. See 
		/// Gl.PixelStore.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int PACK_ROW_LENGTH = 0x0D02;

		/// <summary>
		/// Gl.Get: data returns one value, the number of rows of pixel locations skipped before the first pixel is written into 
		/// memory. The initial value is 0. See Gl.PixelStore.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int PACK_SKIP_ROWS = 0x0D03;

		/// <summary>
		/// Gl.Get: data returns one value, the number of pixel locations skipped before the first pixel is written into memory. The 
		/// initial value is 0. See Gl.PixelStore.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public const int PACK_SKIP_PIXELS = 0x0D04;

		/// <summary>
		/// Gl.Get: data returns one value, the byte alignment used for writing pixel data to memory. The initial value is 4. See 
		/// Gl.PixelStore.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int PACK_ALIGNMENT = 0x0D05;

		/// <summary>
		/// Gl.Get: data returns one value. The value gives a rough estimate of the largest texture that the GL can handle. The 
		/// value must be at least 1024. Use a proxy texture target such as Gl.PROXY_TEXTURE_1D or Gl.PROXY_TEXTURE_2D to determine 
		/// if a texture is too large. See Gl.TexImage1D and Gl.TexImage2D.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int MAX_TEXTURE_SIZE = 0x0D33;

		/// <summary>
		/// Gl.Get: data returns two values: the maximum supported width and height of the viewport. These must be at least as large 
		/// as the visible dimensions of the display being rendered to. See Gl.Viewport.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int MAX_VIEWPORT_DIMS = 0x0D3A;

		/// <summary>
		/// Gl.Get: data returns one value, an estimate of the number of bits of subpixel resolution that are used to position 
		/// rasterized geometry in window coordinates. The value must be at least 4.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int SUBPIXEL_BITS = 0x0D50;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled and no fragment shader is active, one-dimensional texturing is performed (unless two- or 
		/// three-dimensional or cube-mapped texturing is also enabled). See Gl.TexImage1D.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D texture mapping is enabled. The initial value is 
		/// Gl.FALSE. See Gl.TexImage1D.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		public const int TEXTURE_1D = 0x0DE0;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled and no fragment shader is active, two-dimensional texturing is performed (unless three-dimensional 
		/// or cube-mapped texturing is also enabled). See Gl.TexImage2D.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D texture mapping is enabled. The initial value is 
		/// Gl.FALSE. See Gl.TexImage2D.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_internalformat_query2", Api = "gl|glcore")]
		[RequiredByFeature("GL_EXT_sparse_texture", Api = "gles2")]
		public const int TEXTURE_2D = 0x0DE1;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single value, the width of the texture image. The initial value is 0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		public const int TEXTURE_WIDTH = 0x1000;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single value, the height of the texture image. The initial value is 0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		public const int TEXTURE_HEIGHT = 0x1001;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: Returns four integer or floating-point numbers that comprise the RGBA color of the texture 
		/// border. Floating-point values are returned in the range 01. Integer values are returned as a linear mapping of the 
		/// internal floating-point representation such that 1.0 maps to the most positive representable integer and -1.0 maps to 
		/// the most negative representable integer. The initial value is (0, 0, 0, 0).
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: Returns four integer or floating-point numbers that comprise the RGBA color of the texture border. 
		/// Floating-point values are returned in the range 01. Integer values are returned as a linear mapping of the internal 
		/// floating-point representation such that 1.0 maps to the most positive representable integer and -1.0 maps to the most 
		/// negative representable integer. The initial value is (0, 0, 0, 0).
		/// </para>
		/// </summary>
		[AliasOf("GL_TEXTURE_BORDER_COLOR_EXT")]
		[AliasOf("GL_TEXTURE_BORDER_COLOR_NV")]
		[AliasOf("GL_TEXTURE_BORDER_COLOR_OES")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_EXT_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_NV_texture_border_clamp", Api = "gles2")]
		[RequiredByFeature("GL_OES_texture_border_clamp", Api = "gles2")]
		public const int TEXTURE_BORDER_COLOR = 0x1004;

		/// <summary>
		/// Gl.Hint: No preference.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int DONT_CARE = 0x1100;

		/// <summary>
		/// Gl.Hint: The most efficient option should be chosen.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int FASTEST = 0x1101;

		/// <summary>
		/// Gl.Hint: The most correct, or highest quality, option should be chosen.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int NICEST = 0x1102;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of signed bytes, each in the range -128 through 127.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		[RequiredByFeature("GL_OES_byte_coordinates", Api = "gl|gles1")]
		public const int BYTE = 0x1400;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of unsigned bytes, each in the range 0 through 255.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int UNSIGNED_BYTE = 0x1401;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of signed two-byte integers, each in the range -32768 through 32767.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_render_snorm", Api = "gles2")]
		public const int SHORT = 0x1402;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of unsigned two-byte integers, each in the range 0 through 65535.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		public const int UNSIGNED_SHORT = 0x1403;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of signed four-byte integers.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int INT = 0x1404;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of unsigned four-byte integers.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_element_index_uint", Api = "gles1|gles2")]
		public const int UNSIGNED_INT = 0x1405;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of four-byte floating-point values.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ARB_vertex_shader")]
		[RequiredByFeature("GL_OES_texture_float", Api = "gles2")]
		public const int FLOAT = 0x1406;

		/// <summary>
		/// Gl.GetError: An attempt has been made to perform an operation that would cause an internal stack to overflow.
		/// </summary>
		[AliasOf("GL_STACK_OVERFLOW_KHR")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int STACK_OVERFLOW = 0x0503;

		/// <summary>
		/// Gl.GetError: An attempt has been made to perform an operation that would cause an internal stack to underflow.
		/// </summary>
		[AliasOf("GL_STACK_UNDERFLOW_KHR")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_3")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RequiredByFeature("GL_KHR_debug", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int STACK_UNDERFLOW = 0x0504;

		/// <summary>
		/// Value of GL_CLEAR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int CLEAR = 0x1500;

		/// <summary>
		/// Value of GL_AND symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int AND = 0x1501;

		/// <summary>
		/// Value of GL_AND_REVERSE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int AND_REVERSE = 0x1502;

		/// <summary>
		/// Value of GL_COPY symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int COPY = 0x1503;

		/// <summary>
		/// Value of GL_AND_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int AND_INVERTED = 0x1504;

		/// <summary>
		/// Value of GL_NOOP symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int NOOP = 0x1505;

		/// <summary>
		/// Value of GL_XOR symbol.
		/// </summary>
		[AliasOf("GL_XOR_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int XOR = 0x1506;

		/// <summary>
		/// Value of GL_OR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int OR = 0x1507;

		/// <summary>
		/// Value of GL_NOR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int NOR = 0x1508;

		/// <summary>
		/// Value of GL_EQUIV symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int EQUIV = 0x1509;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: Bitwise inverts the current stencil buffer value.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: Bitwise inverts the current stencil buffer value.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int INVERT = 0x150A;

		/// <summary>
		/// Value of GL_OR_REVERSE symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int OR_REVERSE = 0x150B;

		/// <summary>
		/// Value of GL_COPY_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int COPY_INVERTED = 0x150C;

		/// <summary>
		/// Value of GL_OR_INVERTED symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int OR_INVERTED = 0x150D;

		/// <summary>
		/// Value of GL_NAND symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int NAND = 0x150E;

		/// <summary>
		/// Value of GL_SET symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public const int SET = 0x150F;

		/// <summary>
		/// Gl.MatrixMode: Applies subsequent matrix operations to the texture matrix stack.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int TEXTURE = 0x1702;

		/// <summary>
		/// <para>
		/// Gl.CopyPixels: Indices or RGBA colors are read from the buffer currently specified as the read source buffer (see 
		/// Gl.ReadBuffer). If the GL is in color index mode, each index that is read from this buffer is converted to a fixed-point 
		/// format with an unspecified number of bits to the right of the binary point. Each index is then shifted left by 
		/// Gl.INDEX_SHIFT bits, and added to Gl.INDEX_OFFSET. If Gl.INDEX_SHIFT is negative, the shift is to the right. In either 
		/// case, zero bits fill otherwise unspecified bit locations in the result. If Gl.MAP_COLOR is true, the index is replaced 
		/// with the value that it references in lookup table Gl.PIXEL_MAP_I_TO_I. Whether the lookup replacement of the index is 
		/// done or not, the integer part of the index is then ANDed with 2b-1, where b is the number of bits in a color index 
		/// buffer. If the GL is in RGBA mode, the red, green, blue, and alpha components of each pixel that is read are converted 
		/// to an internal floating-point format with unspecified precision. The conversion maps the largest representable component 
		/// value to 1.0, and component value 0 to 0.0. The resulting floating-point color values are then multiplied by Gl.c_SCALE 
		/// and added to Gl.c_BIAS, where c is RED, GREEN, BLUE, and ALPHA for the respective color components. The results are 
		/// clamped to the range [0,1]. If Gl.MAP_COLOR is true, each color component is scaled by the size of lookup table 
		/// Gl.PIXEL_MAP_c_TO_c, then replaced by the value that it references in that table. c is R, G, B, or A. If the ARB_imaging 
		/// extension is supported, the color values may be additionally processed by color-table lookups, color-matrix 
		/// transformations, and convolution filters. The GL then converts the resulting indices or RGBA colors to fragments by 
		/// attaching the current raster position z coordinate and texture coordinates to each pixel, then assigning window 
		/// coordinates xr+iyr+j, where xryr is the current raster position, and the pixel was the ith pixel in the jth row. These 
		/// pixel fragments are then treated just like the fragments generated by rasterizing points, lines, or polygons. Texture 
		/// mapping, fog, and all the fragment operations are applied before the fragments are written to the frame buffer.
		/// </para>
		/// <para>
		/// Gl.MatrixMode: Applies subsequent matrix operations to the color matrix stack.
		/// </para>
		/// </summary>
		[AliasOf("GL_COLOR_EXT")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
		public const int COLOR = 0x1800;

		/// <summary>
		/// Gl.CopyPixels: Depth values are read from the depth buffer and converted directly to an internal floating-point format 
		/// with unspecified precision. The resulting floating-point depth value is then multiplied by Gl.DEPTH_SCALE and added to 
		/// Gl.DEPTH_BIAS. The result is clamped to the range [0,1]. The GL then converts the resulting depth components to 
		/// fragments by attaching the current raster position color or color index and texture coordinates to each pixel, then 
		/// assigning window coordinates xr+iyr+j, where xryr is the current raster position, and the pixel was the ith pixel in the 
		/// jth row. These pixel fragments are then treated just like the fragments generated by rasterizing points, lines, or 
		/// polygons. Texture mapping, fog, and all the fragment operations are applied before the fragments are written to the 
		/// frame buffer.
		/// </summary>
		[AliasOf("GL_DEPTH_EXT")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
		public const int DEPTH = 0x1801;

		/// <summary>
		/// Gl.CopyPixels: Stencil indices are read from the stencil buffer and converted to an internal fixed-point format with an 
		/// unspecified number of bits to the right of the binary point. Each fixed-point index is then shifted left by 
		/// Gl.INDEX_SHIFT bits, and added to Gl.INDEX_OFFSET. If Gl.INDEX_SHIFT is negative, the shift is to the right. In either 
		/// case, zero bits fill otherwise unspecified bit locations in the result. If Gl.MAP_STENCIL is true, the index is replaced 
		/// with the value that it references in lookup table Gl.PIXEL_MAP_S_TO_S. Whether the lookup replacement of the index is 
		/// done or not, the integer part of the index is then ANDed with 2b-1, where b is the number of bits in the stencil buffer. 
		/// The resulting stencil indices are then written to the stencil buffer such that the index read from the ith location of 
		/// the jth row is written to location xr+iyr+j, where xryr is the current raster position. Only the pixel ownership test, 
		/// the scissor test, and the stencil writemask affect these write operations.
		/// </summary>
		[AliasOf("GL_STENCIL_EXT")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_EXT_discard_framebuffer", Api = "gles1|gles2")]
		public const int STENCIL = 0x1802;

		/// <summary>
		/// <para>
		/// Gl.DrawPixels: Each pixel is a single value, a stencil index. It is converted to fixed-point format, with an unspecified 
		/// number of bits to the right of the binary point, regardless of the memory data type. Floating-point values convert to 
		/// true fixed-point values. Signed and unsigned integer data is converted with all fraction bits set to 0. Bitmap data 
		/// convert to either 0 or 1. Each fixed-point index is then shifted left by Gl.INDEX_SHIFT bits, and added to 
		/// Gl.INDEX_OFFSET. If Gl.INDEX_SHIFT is negative, the shift is to the right. In either case, zero bits fill otherwise 
		/// unspecified bit locations in the result. If Gl.MAP_STENCIL is true, the index is replaced with the value that it 
		/// references in lookup table Gl.PIXEL_MAP_S_TO_S. Whether the lookup replacement of the index is done or not, the integer 
		/// part of the index is then ANDed with 2b-1, where b is the number of bits in the stencil buffer. The resulting stencil 
		/// indices are then written to the stencil buffer such that the nth index is written to location xn=xr+n%widthyn=yr+nwidth 
		/// where xryr is the current raster position. Only the pixel ownership test, the scissor test, and the stencil writemask 
		/// affect these write operations.
		/// </para>
		/// <para>
		/// Gl.ReadPixels: Stencil values are read from the stencil buffer. Each index is converted to fixed point, shifted left or 
		/// right depending on the value and sign of Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET. If Gl.MAP_STENCIL is Gl.TRUE, 
		/// indices are replaced by their mappings in the table Gl.PIXEL_MAP_S_TO_S.
		/// </para>
		/// </summary>
		[AliasOf("GL_STENCIL_INDEX_OES")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_4_4")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		[RequiredByFeature("GL_ES_VERSION_3_2", Api = "gles2")]
		[RequiredByFeature("GL_ARB_texture_stencil8", Api = "gl|glcore")]
		[RequiredByFeature("GL_OES_texture_stencil8", Api = "gles2")]
		public const int STENCIL_INDEX = 0x1901;

		/// <summary>
		/// <para>
		/// Gl.DrawPixels: Each pixel is a single-depth component. Floating-point data is converted directly to an internal 
		/// floating-point format with unspecified precision. Signed integer data is mapped linearly to the internal floating-point 
		/// format such that the most positive representable integer value maps to 1.0, and the most negative representable value 
		/// maps to -1.0. Unsigned integer data is mapped similarly: the largest integer value maps to 1.0, and 0 maps to 0.0. The 
		/// resulting floating-point depth value is then multiplied by Gl.DEPTH_SCALE and added to Gl.DEPTH_BIAS. The result is 
		/// clamped to the range 01. The GL then converts the resulting depth components to fragments by attaching the current 
		/// raster position color or color index and texture coordinates to each pixel, then assigning x and y window coordinates to 
		/// the nth fragment such that xn=xr+n%widthyn=yr+nwidth where xryr is the current raster position. These pixel fragments 
		/// are then treated just like the fragments generated by rasterizing points, lines, or polygons. Texture mapping, fog, and 
		/// all the fragment operations are applied before the fragments are written to the frame buffer.
		/// </para>
		/// <para>
		/// Gl.ReadPixels: Depth values are read from the depth buffer. Each component is converted to floating point such that the 
		/// minimum depth value maps to 0 and the maximum value maps to 1. Each component is then multiplied by Gl.DEPTH_SCALE, 
		/// added to Gl.DEPTH_BIAS, and finally clamped to the range 01.
		/// </para>
		/// <para>
		/// Gl.TexImage1D: Each element is a single depth value. The GL converts it to floating point, multiplies by the signed 
		/// scale factor Gl.DEPTH_SCALE, adds the signed bias Gl.DEPTH_BIAS, and clamps to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: Each element is a single depth value. The GL converts it to floating point, multiplies by the signed 
		/// scale factor Gl.DEPTH_SCALE, adds the signed bias Gl.DEPTH_BIAS, and clamps to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_ANGLE_depth_texture", Api = "gles2")]
		[RequiredByFeature("GL_OES_depth_texture", Api = "gles2")]
		public const int DEPTH_COMPONENT = 0x1902;

		/// <summary>
		/// <para>
		/// Gl.DrawPixels: Each pixel is a single red component. This component is converted to the internal floating-point format 
		/// in the same way the red component of an RGBA pixel is. It is then converted to an RGBA pixel with green and blue set to 
		/// 0, and alpha set to 1. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
		/// </para>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: Each element is a single red component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for green and blue, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: Each element is a single red component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for green and blue, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: Each element is a single red component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for green and blue, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// </summary>
		[AliasOf("GL_RED_EXT")]
		[AliasOf("GL_RED_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_EXT_texture_rg", Api = "gles2")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int RED = 0x1903;

		/// <summary>
		/// <para>
		/// Gl.DrawPixels: Each pixel is a single green component. This component is converted to the internal floating-point format 
		/// in the same way the green component of an RGBA pixel is. It is then converted to an RGBA pixel with red and blue set to 
		/// 0, and alpha set to 1. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
		/// </para>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: Each element is a single green component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red and blue, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: Each element is a single green component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red and blue, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: Each element is a single green component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red and blue, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// </summary>
		[AliasOf("GL_GREEN_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int GREEN = 0x1904;

		/// <summary>
		/// <para>
		/// Gl.DrawPixels: Each pixel is a single blue component. This component is converted to the internal floating-point format 
		/// in the same way the blue component of an RGBA pixel is. It is then converted to an RGBA pixel with red and green set to 
		/// 0, and alpha set to 1. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
		/// </para>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: Each element is a single blue component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red and green, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: Each element is a single blue component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red and green, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: Each element is a single blue component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red and green, and 1 for alpha. Each component is then multiplied by the signed scale 
		/// factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// </summary>
		[AliasOf("GL_BLUE_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		[RequiredByFeature("GL_NV_blend_equation_advanced", Api = "gl|glcore|gles2")]
		public const int BLUE = 0x1905;

		/// <summary>
		/// <para>
		/// Gl.DrawPixels: Each pixel is a single alpha component. This component is converted to the internal floating-point format 
		/// in the same way the alpha component of an RGBA pixel is. It is then converted to an RGBA pixel with red, green, and blue 
		/// set to 0. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
		/// </para>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: Each element is a single alpha component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red, green, and blue. Each component is then multiplied by the signed scale factor 
		/// Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: Each element is a single alpha component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red, green, and blue. Each component is then multiplied by the signed scale factor 
		/// Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: Each element is a single alpha component. The GL converts it to floating point and assembles it into an 
		/// RGBA element by attaching 0 for red, green, and blue. Each component is then multiplied by the signed scale factor 
		/// Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RequiredByFeature("GL_AMD_interleaved_elements")]
		public const int ALPHA = 0x1906;

		/// <summary>
		/// <para>
		/// Gl.DrawPixels: 
		/// </para>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: 
		/// </para>
		/// <para>
		/// Gl.TexImage2D: 
		/// </para>
		/// <para>
		/// Gl.TexImage3D: 
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int RGB = 0x1907;

		/// <summary>
		/// <para>
		/// Gl.DrawPixels: 
		/// </para>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: 
		/// </para>
		/// <para>
		/// Gl.TexImage2D: 
		/// </para>
		/// <para>
		/// Gl.TexImage3D: 
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int RGBA = 0x1908;

		/// <summary>
		/// Gl.PolygonMode: Polygon vertices that are marked as the start of a boundary edge are drawn as points. Point attributes 
		/// such as Gl.POINT_SIZE and Gl.POINT_SMOOTH control the rasterization of the points. Polygon rasterization attributes 
		/// other than Gl.POLYGON_MODE have no effect.
		/// </summary>
		[AliasOf("GL_POINT_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		public const int POINT = 0x1B00;

		/// <summary>
		/// Gl.PolygonMode: Boundary edges of the polygon are drawn as line segments. Line attributes such as Gl.LINE_WIDTH and 
		/// Gl.LINE_SMOOTH control the rasterization of the lines. Polygon rasterization attributes other than Gl.POLYGON_MODE have 
		/// no effect.
		/// </summary>
		[AliasOf("GL_LINE_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		public const int LINE = 0x1B01;

		/// <summary>
		/// Gl.PolygonMode: The interior of the polygon is filled. Polygon attributes such as Gl.POLYGON_SMOOTH control the 
		/// rasterization of the polygon.
		/// </summary>
		[AliasOf("GL_FILL_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		public const int FILL = 0x1B02;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: Keeps the current value.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: Keeps the current value.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int KEEP = 0x1E00;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: Sets the stencil buffer value to ref, as specified by Gl.StencilFunc.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: Sets the stencil buffer value to ref, as specified by Gl.StencilFunc.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int REPLACE = 0x1E01;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: Increments the current stencil buffer value. Clamps to the maximum representable unsigned value.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: Increments the current stencil buffer value. Clamps to the maximum representable unsigned value.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int INCR = 0x1E02;

		/// <summary>
		/// <para>
		/// Gl.StencilOp: Decrements the current stencil buffer value. Clamps to 0.
		/// </para>
		/// <para>
		/// Gl.StencilOpSeparate: Decrements the current stencil buffer value. Clamps to 0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int DECR = 0x1E03;

		/// <summary>
		/// Gl.GetString: Returns the company responsible for this GL implementation. This name does not change from release to 
		/// release.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int VENDOR = 0x1F00;

		/// <summary>
		/// Gl.GetString: Returns the name of the renderer. This name is typically specific to a particular configuration of a 
		/// hardware platform. It does not change from release to release.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int RENDERER = 0x1F01;

		/// <summary>
		/// Gl.GetString: Returns a version or release number.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int VERSION = 0x1F02;

		/// <summary>
		/// Gl.GetString: For glGetStringi only, returns the extension string supported by the implementation at index.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int EXTENSIONS = 0x1F03;

		/// <summary>
		/// Value of GL_NEAREST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int NEAREST = 0x2600;

		/// <summary>
		/// Value of GL_LINEAR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int LINEAR = 0x2601;

		/// <summary>
		/// Value of GL_NEAREST_MIPMAP_NEAREST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int NEAREST_MIPMAP_NEAREST = 0x2700;

		/// <summary>
		/// Value of GL_LINEAR_MIPMAP_NEAREST symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int LINEAR_MIPMAP_NEAREST = 0x2701;

		/// <summary>
		/// Value of GL_NEAREST_MIPMAP_LINEAR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int NEAREST_MIPMAP_LINEAR = 0x2702;

		/// <summary>
		/// Value of GL_LINEAR_MIPMAP_LINEAR symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int LINEAR_MIPMAP_LINEAR = 0x2703;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: Returns the single-valued texture magnification filter, a symbolic constant. The initial value 
		/// is Gl.LINEAR.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: Returns the single-valued texture magnification filter, a symbolic constant. The initial value is 
		/// Gl.LINEAR.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int TEXTURE_MAG_FILTER = 0x2800;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: Returns the single-valued texture minification filter, a symbolic constant. The initial value is 
		/// Gl.NEAREST_MIPMAP_LINEAR.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: Returns the single-valued texture minification filter, a symbolic constant. The initial value is 
		/// Gl.NEAREST_MIPMAP_LINEAR.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int TEXTURE_MIN_FILTER = 0x2801;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: Returns the single-valued wrapping function for texture coordinate s, a symbolic constant. The 
		/// initial value is Gl.REPEAT.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: Returns the single-valued wrapping function for texture coordinate s, a symbolic constant. The 
		/// initial value is Gl.REPEAT.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int TEXTURE_WRAP_S = 0x2802;

		/// <summary>
		/// <para>
		/// Gl.GetSamplerParameter: Returns the single-valued wrapping function for texture coordinate t, a symbolic constant. The 
		/// initial value is Gl.REPEAT.
		/// </para>
		/// <para>
		/// Gl.GetTexParameter: Returns the single-valued wrapping function for texture coordinate t, a symbolic constant. The 
		/// initial value is Gl.REPEAT.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int TEXTURE_WRAP_T = 0x2803;

		/// <summary>
		/// Value of GL_REPEAT symbol.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public const int REPEAT = 0x2901;

		/// <summary>
		/// Value of GL_CURRENT_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint CURRENT_BIT = 0x00000001;

		/// <summary>
		/// Value of GL_POINT_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint POINT_BIT = 0x00000002;

		/// <summary>
		/// Value of GL_LINE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint LINE_BIT = 0x00000004;

		/// <summary>
		/// Value of GL_POLYGON_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint POLYGON_BIT = 0x00000008;

		/// <summary>
		/// Value of GL_POLYGON_STIPPLE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint POLYGON_STIPPLE_BIT = 0x00000010;

		/// <summary>
		/// Value of GL_PIXEL_MODE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint PIXEL_MODE_BIT = 0x00000020;

		/// <summary>
		/// Value of GL_LIGHTING_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint LIGHTING_BIT = 0x00000040;

		/// <summary>
		/// Value of GL_FOG_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint FOG_BIT = 0x00000080;

		/// <summary>
		/// Gl.Clear: Indicates the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint ACCUM_BUFFER_BIT = 0x00000200;

		/// <summary>
		/// Value of GL_VIEWPORT_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint VIEWPORT_BIT = 0x00000800;

		/// <summary>
		/// Value of GL_TRANSFORM_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint TRANSFORM_BIT = 0x00001000;

		/// <summary>
		/// Value of GL_ENABLE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint ENABLE_BIT = 0x00002000;

		/// <summary>
		/// Value of GL_HINT_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint HINT_BIT = 0x00008000;

		/// <summary>
		/// Value of GL_EVAL_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint EVAL_BIT = 0x00010000;

		/// <summary>
		/// Value of GL_LIST_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint LIST_BIT = 0x00020000;

		/// <summary>
		/// Value of GL_TEXTURE_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint TEXTURE_BIT = 0x00040000;

		/// <summary>
		/// Value of GL_SCISSOR_BIT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint SCISSOR_BIT = 0x00080000;

		/// <summary>
		/// Value of GL_ALL_ATTRIB_BITS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		[Log(BitmaskName = "GL")]
		public const uint ALL_ATTRIB_BITS = 0xFFFFFFFF;

		/// <summary>
		/// Gl.Begin: Draws a connected group of quadrilaterals. One quadrilateral is defined for each pair of vertices presented 
		/// after the first pair. Vertices 2⁢n-1, 2⁢n, 2⁢n+2, and 2⁢n+1 define quadrilateral n. N2-1 quadrilaterals are drawn. Note 
		/// that the order in which vertices are used to construct a quadrilateral from strip data is different from that used with 
		/// independent data.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int QUAD_STRIP = 0x0008;

		/// <summary>
		/// Gl.Begin: Draws a single, convex polygon. Vertices 1 through N define this polygon.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int POLYGON = 0x0009;

		/// <summary>
		/// Gl.Accum: Obtains R, G, B, and A values from the buffer currently selected for reading (see Gl.ReadBuffer). Each 
		/// component value is divided by 2n-1, where n is the number of bits allocated to each color component in the currently 
		/// selected buffer. The result is a floating-point value in the range 01, which is multiplied by value and added to the 
		/// corresponding pixel component in the accumulation buffer, thereby updating the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ACCUM = 0x0100;

		/// <summary>
		/// Gl.Accum: Similar to Gl.ACCUM, except that the current value in the accumulation buffer is not used in the calculation 
		/// of the new value. That is, the R, G, B, and A values from the currently selected buffer are divided by 2n-1, multiplied 
		/// by value, and then stored in the corresponding accumulation buffer cell, overwriting the current value.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LOAD = 0x0101;

		/// <summary>
		/// Gl.Accum: Transfers accumulation buffer values to the color buffer or buffers currently selected for writing. Each R, G, 
		/// B, and A component is multiplied by value, then multiplied by 2n-1, clamped to the range 02n-1, and stored in the 
		/// corresponding display buffer cell. The only fragment operations that are applied to this transfer are pixel ownership, 
		/// scissor, dithering, and color writemasks.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int RETURN = 0x0102;

		/// <summary>
		/// Gl.Accum: Multiplies each R, G, B, and A in the accumulation buffer by value and returns the scaled component to its 
		/// corresponding accumulation buffer location.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MULT = 0x0103;

		/// <summary>
		/// Gl.Accum: Adds value to each R, G, B, and A in the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ADD = 0x0104;

		/// <summary>
		/// Value of GL_AUX0 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int AUX0 = 0x0409;

		/// <summary>
		/// Value of GL_AUX1 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int AUX1 = 0x040A;

		/// <summary>
		/// Value of GL_AUX2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int AUX2 = 0x040B;

		/// <summary>
		/// Value of GL_AUX3 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int AUX3 = 0x040C;

		/// <summary>
		/// Value of GL_2D symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int _2D = 0x0600;

		/// <summary>
		/// Value of GL_3D symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int _3D = 0x0601;

		/// <summary>
		/// Value of GL_3D_COLOR symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int _3D_COLOR = 0x0602;

		/// <summary>
		/// Value of GL_3D_COLOR_TEXTURE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int _3D_COLOR_TEXTURE = 0x0603;

		/// <summary>
		/// Value of GL_4D_COLOR_TEXTURE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int _4D_COLOR_TEXTURE = 0x0604;

		/// <summary>
		/// Value of GL_PASS_THROUGH_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PASS_THROUGH_TOKEN = 0x0700;

		/// <summary>
		/// Value of GL_POINT_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int POINT_TOKEN = 0x0701;

		/// <summary>
		/// Value of GL_LINE_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LINE_TOKEN = 0x0702;

		/// <summary>
		/// Value of GL_POLYGON_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int POLYGON_TOKEN = 0x0703;

		/// <summary>
		/// Value of GL_BITMAP_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int BITMAP_TOKEN = 0x0704;

		/// <summary>
		/// Value of GL_DRAW_PIXEL_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int DRAW_PIXEL_TOKEN = 0x0705;

		/// <summary>
		/// Value of GL_COPY_PIXEL_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COPY_PIXEL_TOKEN = 0x0706;

		/// <summary>
		/// Value of GL_LINE_RESET_TOKEN symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LINE_RESET_TOKEN = 0x0707;

		/// <summary>
		/// Value of GL_EXP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int EXP = 0x0800;

		/// <summary>
		/// Value of GL_EXP2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int EXP2 = 0x0801;

		/// <summary>
		/// Gl.GetMap: v returns the control points for the evaluator function. One-dimensional evaluators return order control 
		/// points, and two-dimensional evaluators return uorder×vorder control points. Each control point consists of one, two, 
		/// three, or four integer, single-precision floating-point, or double-precision floating-point values, depending on the 
		/// type of the evaluator. The GL returns two-dimensional control points in row-major order, incrementing the uorder index 
		/// quickly and the vorder index after each row. Integer values, when requested, are computed by rounding the internal 
		/// floating-point values to the nearest integer values.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COEFF = 0x0A00;

		/// <summary>
		/// Gl.GetMap: v returns the order of the evaluator function. One-dimensional evaluators return a single value, order. The 
		/// initial value is 1. Two-dimensional evaluators return two values, uorder and vorder. The initial value is 1,1.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ORDER = 0x0A01;

		/// <summary>
		/// Gl.GetMap: v returns the linear u and v mapping parameters. One-dimensional evaluators return two values, u1 and u2, as 
		/// specified by Gl.Map1. Two-dimensional evaluators return four values (u1, u2, v1, and v2) as specified by Gl.Map2. 
		/// Integer values, when requested, are computed by rounding the internal floating-point values to the nearest integer 
		/// values.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int DOMAIN = 0x0A02;

		/// <summary>
		/// Gl.PixelMap: Maps color indices to color indices.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_I_TO_I = 0x0C70;

		/// <summary>
		/// Gl.PixelMap: Maps stencil indices to stencil indices.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_S_TO_S = 0x0C71;

		/// <summary>
		/// Gl.PixelMap: Maps color indices to red components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_I_TO_R = 0x0C72;

		/// <summary>
		/// Gl.PixelMap: Maps color indices to green components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_I_TO_G = 0x0C73;

		/// <summary>
		/// Gl.PixelMap: Maps color indices to blue components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_I_TO_B = 0x0C74;

		/// <summary>
		/// Gl.PixelMap: Maps color indices to alpha components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_I_TO_A = 0x0C75;

		/// <summary>
		/// Gl.PixelMap: Maps red components to red components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_R_TO_R = 0x0C76;

		/// <summary>
		/// Gl.PixelMap: Maps green components to green components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_G_TO_G = 0x0C77;

		/// <summary>
		/// Gl.PixelMap: Maps blue components to blue components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_B_TO_B = 0x0C78;

		/// <summary>
		/// Gl.PixelMap: Maps alpha components to alpha components.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_A_TO_A = 0x0C79;

		/// <summary>
		/// Gl.Get: params returns four values: the red, green, blue, and alpha values of the current color. Integer values, if 
		/// requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most positive 
		/// representable integer value, and -1.0 returns the most negative representable integer value. The initial value is (1, 1, 
		/// 1, 1). See Gl.Color.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CURRENT_COLOR = 0x0B00;

		/// <summary>
		/// Gl.Get: params returns one value, the current color index. The initial value is 1. See Gl.Index.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CURRENT_INDEX = 0x0B01;

		/// <summary>
		/// Gl.Get: params returns three values: the x, y, and z values of the current normal. Integer values, if requested, are 
		/// linearly mapped from the internal floating-point representation such that 1.0 returns the most positive representable 
		/// integer value, and -1.0 returns the most negative representable integer value. The initial value is (0, 0, 1). See 
		/// Gl.Normal.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CURRENT_NORMAL = 0x0B02;

		/// <summary>
		/// Gl.Get: params returns four values: the s, t, r, and q current texture coordinates. The initial value is (0, 0, 0, 1). 
		/// See Gl.MultiTexCoord.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CURRENT_TEXTURE_COORDS = 0x0B03;

		/// <summary>
		/// Gl.Get: params returns four values: the red, green, blue, and alpha color values of the current raster position. Integer 
		/// values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most 
		/// positive representable integer value, and -1.0 returns the most negative representable integer value. The initial value 
		/// is (1, 1, 1, 1). See Gl.RasterPos.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CURRENT_RASTER_COLOR = 0x0B04;

		/// <summary>
		/// Gl.Get: params returns one value, the color index of the current raster position. The initial value is 1. See 
		/// Gl.RasterPos.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CURRENT_RASTER_INDEX = 0x0B05;

		/// <summary>
		/// Gl.Get: params returns four values: the s, t, r, and q texture coordinates of the current raster position. The initial 
		/// value is (0, 0, 0, 1). See Gl.RasterPos and Gl.MultiTexCoord.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;

		/// <summary>
		/// Gl.Get: params returns four values: the x, y, z, and w components of the current raster position. x, y, and z are in 
		/// window coordinates, and w is in clip coordinates. The initial value is (0, 0, 0, 1). See Gl.RasterPos.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CURRENT_RASTER_POSITION = 0x0B07;

		/// <summary>
		/// Gl.Get: params returns a single boolean value indicating whether the current raster position is valid. The initial value 
		/// is Gl.TRUE. See Gl.RasterPos.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CURRENT_RASTER_POSITION_VALID = 0x0B08;

		/// <summary>
		/// Gl.Get: params returns one value, the distance from the eye to the current raster position. The initial value is 0. See 
		/// Gl.RasterPos.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CURRENT_RASTER_DISTANCE = 0x0B09;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, draw points with proper filtering. Otherwise, draw aliased points. See Gl.PointSize.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether antialiasing of points is enabled. The initial value is 
		/// Gl.FALSE. See Gl.PointSize.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int POINT_SMOOTH = 0x0B10;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, use the current line stipple pattern when drawing lines. See Gl.LineStipple.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether stippling of lines is enabled. The initial value is 
		/// Gl.FALSE. See Gl.LineStipple.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LINE_STIPPLE = 0x0B24;

		/// <summary>
		/// Gl.Get: params returns one value, the 16-bit line stipple pattern. The initial value is all 1's. See Gl.LineStipple.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LINE_STIPPLE_PATTERN = 0x0B25;

		/// <summary>
		/// Gl.Get: params returns one value, the line stipple repeat factor. The initial value is 1. See Gl.LineStipple.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LINE_STIPPLE_REPEAT = 0x0B26;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating the construction mode of the display list currently 
		/// under construction. The initial value is 0. See Gl.NewList.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIST_MODE = 0x0B30;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum recursion depth allowed during display-list traversal. The value must be 
		/// at least 64. See Gl.CallList.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAX_LIST_NESTING = 0x0B31;

		/// <summary>
		/// Gl.Get: params returns one value, the base offset added to all names in arrays presented to Gl.CallLists. The initial 
		/// value is 0. See Gl.ListBase.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIST_BASE = 0x0B32;

		/// <summary>
		/// Gl.Get: params returns one value, the name of the display list currently under construction. 0 is returned if no display 
		/// list is currently under construction. The initial value is 0. See Gl.NewList.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIST_INDEX = 0x0B33;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, use the current polygon stipple pattern when rendering polygons. See Gl.PolygonStipple.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether polygon stippling is enabled. The initial value is 
		/// Gl.FALSE. See Gl.PolygonStipple.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int POLYGON_STIPPLE = 0x0B42;

		/// <summary>
		/// Gl.Get: params returns a single boolean value indicating whether the current edge flag is Gl.TRUE or Gl.FALSE. The 
		/// initial value is Gl.TRUE. See Gl.EdgeFlag.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int EDGE_FLAG = 0x0B43;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled and no vertex shader is active, use the current lighting parameters to compute the vertex color or 
		/// index. Otherwise, simply associate the current color or index with each vertex. See Gl.Material, Gl.LightModel, and 
		/// Gl.Light.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether lighting is enabled. The initial value is Gl.FALSE. See 
		/// Gl.LightModel.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIGHTING = 0x0B50;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether specular reflection calculations treat the viewer as 
		/// being local to the scene. The initial value is Gl.FALSE. See Gl.LightModel.
		/// </para>
		/// <para>
		/// Gl.LightModel: params is a single integer or floating-point value that specifies how specular reflection angles are 
		/// computed. If params is 0 (or 0.0), specular reflection angles take the view direction to be parallel to and in the 
		/// direction of the -z axis, regardless of the location of the vertex in eye coordinates. Otherwise, specular reflections 
		/// are computed from the origin of the eye coordinate system. The initial value is 0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether separate materials are used to compute lighting for 
		/// front- and back-facing polygons. The initial value is Gl.FALSE. See Gl.LightModel.
		/// </para>
		/// <para>
		/// Gl.LightModel: params is a single integer or floating-point value that specifies whether one- or two-sided lighting 
		/// calculations are done for polygons. It has no effect on the lighting calculations for points, lines, or bitmaps. If 
		/// params is 0 (or 0.0), one-sided lighting is specified, and only the front material parameters are used in the lighting 
		/// equation. Otherwise, two-sided lighting is specified. In this case, vertices of back-facing polygons are lighted using 
		/// the back material parameters and have their normals reversed before the lighting equation is evaluated. Vertices of 
		/// front-facing polygons are always lighted using the front material parameters, with no change to their normals. The 
		/// initial value is 0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIGHT_MODEL_TWO_SIDE = 0x0B52;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns four values: the red, green, blue, and alpha components of the ambient intensity of the entire 
		/// scene. Integer values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 
		/// returns the most positive representable integer value, and -1.0 returns the most negative representable integer value. 
		/// The initial value is (0.2, 0.2, 0.2, 1.0). See Gl.LightModel.
		/// </para>
		/// <para>
		/// Gl.LightModel: params contains four integer or floating-point values that specify the ambient RGBA intensity of the 
		/// entire scene. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the 
		/// most negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor 
		/// floating-point values are clamped. The initial ambient scene intensity is (0.2, 0.2, 0.2, 1.0).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIGHT_MODEL_AMBIENT = 0x0B53;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating whether the shading mode is flat or smooth. The initial 
		/// value is Gl.SMOOTH. See Gl.ShadeModel.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int SHADE_MODEL = 0x0B54;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating which materials have a parameter that is tracking the 
		/// current color. The initial value is Gl.FRONT_AND_BACK. See Gl.ColorMaterial.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COLOR_MATERIAL_FACE = 0x0B55;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating which material parameters are tracking the current 
		/// color. The initial value is Gl.AMBIENT_AND_DIFFUSE. See Gl.ColorMaterial.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COLOR_MATERIAL_PARAMETER = 0x0B56;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, have one or more material parameters track the current color. See Gl.ColorMaterial.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether one or more material parameters are tracking the 
		/// current color. The initial value is Gl.FALSE. See Gl.ColorMaterial.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COLOR_MATERIAL = 0x0B57;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled and no fragment shader is active, blend a fog color into the post-texturing color. See Gl.Fog.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether fogging is enabled. The initial value is Gl.FALSE. See 
		/// Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_NV_register_combiners")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FOG = 0x0B60;

		/// <summary>
		/// <para>
		/// Gl.Fog: params is a single integer or floating-point value that specifies if, the fog color index. The initial fog index 
		/// is 0.
		/// </para>
		/// <para>
		/// Gl.Get: params returns one value, the fog color index. The initial value is 0. See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FOG_INDEX = 0x0B61;

		/// <summary>
		/// <para>
		/// Gl.Fog: params is a single integer or floating-point value that specifies density, the fog density used in both 
		/// exponential fog equations. Only nonnegative densities are accepted. The initial fog density is 1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns one value, the fog density parameter. The initial value is 1. See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FOG_DENSITY = 0x0B62;

		/// <summary>
		/// <para>
		/// Gl.Fog: params is a single integer or floating-point value that specifies start, the near distance used in the linear 
		/// fog equation. The initial near distance is 0.
		/// </para>
		/// <para>
		/// Gl.Get: params returns one value, the start factor for the linear fog equation. The initial value is 0. See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FOG_START = 0x0B63;

		/// <summary>
		/// <para>
		/// Gl.Fog: params is a single integer or floating-point value that specifies end, the far distance used in the linear fog 
		/// equation. The initial far distance is 1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns one value, the end factor for the linear fog equation. The initial value is 1. See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FOG_END = 0x0B64;

		/// <summary>
		/// <para>
		/// Gl.Fog: params is a single integer or floating-point value that specifies the equation to be used to compute the fog 
		/// blend factor, f. Three symbolic constants are accepted: Gl.LINEAR, Gl.EXP, and Gl.EXP2. The equations corresponding to 
		/// these symbolic constants are defined below. The initial fog mode is Gl.EXP.
		/// </para>
		/// <para>
		/// Gl.Get: params returns one value, a symbolic constant indicating which fog equation is selected. The initial value is 
		/// Gl.EXP. See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FOG_MODE = 0x0B65;

		/// <summary>
		/// <para>
		/// Gl.Fog: params contains four integer or floating-point values that specify Cf, the fog color. Integer values are mapped 
		/// linearly such that the most positive representable value maps to 1.0, and the most negative representable value maps to 
		/// -1.0. Floating-point values are mapped directly. After conversion, all color components are clamped to the range 01. The 
		/// initial fog color is (0, 0, 0, 0).
		/// </para>
		/// <para>
		/// Gl.Get: params returns four values: the red, green, blue, and alpha components of the fog color. Integer values, if 
		/// requested, are linearly mapped from the internal floating-point representation such that 1.0 returns the most positive 
		/// representable integer value, and -1.0 returns the most negative representable integer value. The initial value is (0, 0, 
		/// 0, 0). See Gl.Fog.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FOG_COLOR = 0x0B66;

		/// <summary>
		/// Gl.Get: params returns four values: the red, green, blue, and alpha values used to clear the accumulation buffer. 
		/// Integer values, if requested, are linearly mapped from the internal floating-point representation such that 1.0 returns 
		/// the most positive representable integer value, and -1.0 returns the most negative representable integer value. The 
		/// initial value is (0, 0, 0, 0). See Gl.ClearAccum.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ACCUM_CLEAR_VALUE = 0x0B80;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating which matrix stack is currently the target of all 
		/// matrix operations. The initial value is Gl.MODELVIEW. See Gl.MatrixMode.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MATRIX_MODE = 0x0BA0;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled and no vertex shader is active, normal vectors are normalized to unit length after transformation 
		/// and before lighting. This method is generally less efficient than Gl.RESCALE_NORMAL. See Gl.Normal and Gl.NormalPointer.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether normals are automatically scaled to unit length after 
		/// they have been transformed to eye coordinates. The initial value is Gl.FALSE. See Gl.Normal.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int NORMALIZE = 0x0BA1;

		/// <summary>
		/// Gl.Get: params returns one value, the number of matrices on the modelview matrix stack. The initial value is 1. See 
		/// Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MODELVIEW_STACK_DEPTH = 0x0BA3;

		/// <summary>
		/// Gl.Get: params returns one value, the number of matrices on the projection matrix stack. The initial value is 1. See 
		/// Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PROJECTION_STACK_DEPTH = 0x0BA4;

		/// <summary>
		/// Gl.Get: params returns one value, the number of matrices on the texture matrix stack. The initial value is 1. See 
		/// Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_STACK_DEPTH = 0x0BA5;

		/// <summary>
		/// Gl.Get: params returns sixteen values: the modelview matrix on the top of the modelview matrix stack. Initially this 
		/// matrix is the identity matrix. See Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MODELVIEW_MATRIX = 0x0BA6;

		/// <summary>
		/// Gl.Get: params returns sixteen values: the projection matrix on the top of the projection matrix stack. Initially this 
		/// matrix is the identity matrix. See Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PROJECTION_MATRIX = 0x0BA7;

		/// <summary>
		/// Gl.Get: params returns sixteen values: the texture matrix on the top of the texture matrix stack. Initially this matrix 
		/// is the identity matrix. See Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_MATRIX = 0x0BA8;

		/// <summary>
		/// Gl.Get: params returns one value, the depth of the attribute stack. If the stack is empty, 0 is returned. The initial 
		/// value is 0. See Gl.PushAttrib.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ATTRIB_STACK_DEPTH = 0x0BB0;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, do alpha testing. See Gl.AlphaFunc.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether alpha testing of fragments is enabled. The initial 
		/// value is Gl.FALSE. See Gl.AlphaFunc.
		/// </para>
		/// </summary>
		[AliasOf("GL_ALPHA_TEST_QCOM")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_QCOM_alpha_test", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ALPHA_TEST = 0x0BC0;

		/// <summary>
		/// Gl.Get: the symbolic name of the alpha test function. The initial value is Gl.ALWAYS. See Gl.AlphaFunc.
		/// </summary>
		[AliasOf("GL_ALPHA_TEST_FUNC_QCOM")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_QCOM_alpha_test", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ALPHA_TEST_FUNC = 0x0BC1;

		/// <summary>
		/// Gl.Get: params returns one value, the reference value for the alpha test. The initial value is 0. See Gl.AlphaFunc. An 
		/// integer value, if requested, is linearly mapped from the internal floating-point representation such that 1.0 returns 
		/// the most positive representable integer value, and -1.0 returns the most negative representable integer value.
		/// </summary>
		[AliasOf("GL_ALPHA_TEST_REF_QCOM")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_QCOM_alpha_test", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ALPHA_TEST_REF = 0x0BC2;

		/// <summary>
		/// Value of GL_LOGIC_OP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LOGIC_OP = 0x0BF1;

		/// <summary>
		/// Gl.Get: params returns one value, the number of auxiliary color buffers available.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int AUX_BUFFERS = 0x0C00;

		/// <summary>
		/// Gl.Get: params returns one value, the color index used to clear the color index buffers. The initial value is 0. See 
		/// Gl.ClearIndex.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INDEX_CLEAR_VALUE = 0x0C20;

		/// <summary>
		/// Gl.Get: params returns one value, a mask indicating which bitplanes of each color index buffer can be written. The 
		/// initial value is all 1's. See Gl.IndexMask.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INDEX_WRITEMASK = 0x0C21;

		/// <summary>
		/// Gl.Get: params returns a single boolean value indicating whether the GL is in color index mode (Gl.TRUE) or RGBA mode 
		/// (Gl.FALSE).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INDEX_MODE = 0x0C30;

		/// <summary>
		/// Gl.Get: params returns a single boolean value indicating whether the GL is in RGBA mode (true) or color index mode 
		/// (false). See Gl.Color.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int RGBA_MODE = 0x0C31;

		/// <summary>
		/// Gl.Get: params returns one value, a symbolic constant indicating whether the GL is in render, select, or feedback mode. 
		/// The initial value is Gl.RENDER. See Gl.RenderMode.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int RENDER_MODE = 0x0C40;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns one value, a symbolic constant indicating the mode of the perspective correction hint. The 
		/// initial value is Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// Gl.Hint: Indicates the quality of color, texture coordinate, and fog coordinate interpolation. If perspective-corrected 
		/// parameter interpolation is not efficiently supported by the GL implementation, hinting Gl.DONT_CARE or Gl.FASTEST can 
		/// result in simple linear interpolation of colors and/or texture coordinates.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PERSPECTIVE_CORRECTION_HINT = 0x0C50;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns one value, a symbolic constant indicating the mode of the point antialiasing hint. The initial 
		/// value is Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// Gl.Hint: Indicates the sampling quality of antialiased points. If a larger filter function is applied, hinting Gl.NICEST 
		/// can result in more pixel fragments being generated during rasterization.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int POINT_SMOOTH_HINT = 0x0C51;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns one value, a symbolic constant indicating the mode of the fog hint. The initial value is 
		/// Gl.DONT_CARE. See Gl.Hint.
		/// </para>
		/// <para>
		/// Gl.Hint: Indicates the accuracy of fog calculation. If per-pixel fog calculation is not efficiently supported by the GL 
		/// implementation, hinting Gl.DONT_CARE or Gl.FASTEST can result in per-vertex calculation of fog effects.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FOG_HINT = 0x0C54;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled and no vertex shader is active, the s texture coordinate is computed using the texture generation 
		/// function defined with Gl.TexGen. Otherwise, the current s texture coordinate is used. See Gl.TexGen.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether automatic generation of the S texture coordinate is 
		/// enabled. The initial value is Gl.FALSE. See Gl.TexGen.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_GEN_S = 0x0C60;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled and no vertex shader is active, the t texture coordinate is computed using the texture generation 
		/// function defined with Gl.TexGen. Otherwise, the current t texture coordinate is used. See Gl.TexGen.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether automatic generation of the T texture coordinate is 
		/// enabled. The initial value is Gl.FALSE. See Gl.TexGen.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_GEN_T = 0x0C61;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled and no vertex shader is active, the r texture coordinate is computed using the texture generation 
		/// function defined with Gl.TexGen. Otherwise, the current r texture coordinate is used. See Gl.TexGen.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether automatic generation of the r texture coordinate is 
		/// enabled. The initial value is Gl.FALSE. See Gl.TexGen.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_GEN_R = 0x0C62;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled and no vertex shader is active, the q texture coordinate is computed using the texture generation 
		/// function defined with Gl.TexGen. Otherwise, the current q texture coordinate is used. See Gl.TexGen.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether automatic generation of the q texture coordinate is 
		/// enabled. The initial value is Gl.FALSE. See Gl.TexGen.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_GEN_Q = 0x0C63;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the index-to-index pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the stencil-to-stencil pixel translation table. The initial value is 1. 
		/// See Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the index-to-red pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the index-to-green pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the index-to-blue pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the index-to-alpha pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the red-to-red pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the green-to-green pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the blue-to-blue pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;

		/// <summary>
		/// Gl.Get: params returns one value, the size of the alpha-to-alpha pixel translation table. The initial value is 1. See 
		/// Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;

		/// <summary>
		/// Gl.Get: params returns a single boolean value indicating if colors and color indices are to be replaced by table lookup 
		/// during pixel transfers. The initial value is Gl.FALSE. See Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP_COLOR = 0x0D10;

		/// <summary>
		/// Gl.Get: params returns a single boolean value indicating if stencil indices are to be replaced by table lookup during 
		/// pixel transfers. The initial value is Gl.FALSE. See Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP_STENCIL = 0x0D11;

		/// <summary>
		/// Gl.Get: params returns one value, the amount that color and stencil indices are shifted during pixel transfers. The 
		/// initial value is 0. See Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INDEX_SHIFT = 0x0D12;

		/// <summary>
		/// Gl.Get: params returns one value, the offset added to color and stencil indices during pixel transfers. The initial 
		/// value is 0. See Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INDEX_OFFSET = 0x0D13;

		/// <summary>
		/// Gl.Get: params returns one value, the red scale factor used during pixel transfers. The initial value is 1. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int RED_SCALE = 0x0D14;

		/// <summary>
		/// Gl.Get: params returns one value, the red bias factor used during pixel transfers. The initial value is 0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int RED_BIAS = 0x0D15;

		/// <summary>
		/// Gl.Get: params returns one value, the x pixel zoom factor. The initial value is 1. See Gl.PixelZoom.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ZOOM_X = 0x0D16;

		/// <summary>
		/// Gl.Get: params returns one value, the y pixel zoom factor. The initial value is 1. See Gl.PixelZoom.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ZOOM_Y = 0x0D17;

		/// <summary>
		/// Gl.Get: params returns one value, the green scale factor used during pixel transfers. The initial value is 1. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int GREEN_SCALE = 0x0D18;

		/// <summary>
		/// Gl.Get: params returns one value, the green bias factor used during pixel transfers. The initial value is 0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int GREEN_BIAS = 0x0D19;

		/// <summary>
		/// Gl.Get: params returns one value, the blue scale factor used during pixel transfers. The initial value is 1. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int BLUE_SCALE = 0x0D1A;

		/// <summary>
		/// Gl.Get: params returns one value, the blue bias factor used during pixel transfers. The initial value is 0. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int BLUE_BIAS = 0x0D1B;

		/// <summary>
		/// <para>
		/// Gl.Get: params returns one value, the alpha scale factor used during pixel transfers. The initial value is 1. See 
		/// Gl.PixelTransfer.
		/// </para>
		/// <para>
		/// Gl.GetTexEnv: params returns a single floating-point value representing the current alpha texture combiner scaling 
		/// factor. The initial value is 1.0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ALPHA_SCALE = 0x0D1C;

		/// <summary>
		/// Gl.Get: params returns one value, the alpha bias factor used during pixel transfers. The initial value is 0. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ALPHA_BIAS = 0x0D1D;

		/// <summary>
		/// Gl.Get: params returns one value, the depth scale factor used during pixel transfers. The initial value is 1. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int DEPTH_SCALE = 0x0D1E;

		/// <summary>
		/// Gl.Get: params returns one value, the depth bias factor used during pixel transfers. The initial value is 0. See 
		/// Gl.PixelTransfer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int DEPTH_BIAS = 0x0D1F;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum equation order supported by 1D and 2D evaluators. The value must be at 
		/// least 8. See Gl.Map1 and Gl.Map2.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAX_EVAL_ORDER = 0x0D30;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum number of lights. The value must be at least 8. See Gl.Light.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAX_LIGHTS = 0x0D31;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum number of application-defined clipping planes. The value must be at least 
		/// 6. See Gl.ClipPlane.
		/// </summary>
		[AliasOf("GL_MAX_CLIP_PLANES_IMG")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAX_CLIP_PLANES = 0x0D32;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported size of a Gl.PixelMap lookup table. The value must be at least 
		/// 32. See Gl.PixelMap.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAX_PIXEL_MAP_TABLE = 0x0D34;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported depth of the attribute stack. The value must be at least 16. See 
		/// Gl.PushAttrib.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAX_ATTRIB_STACK_DEPTH = 0x0D35;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported depth of the modelview matrix stack. The value must be at least 
		/// 32. See Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAX_MODELVIEW_STACK_DEPTH = 0x0D36;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported depth of the selection name stack. The value must be at least 
		/// 64. See Gl.PushName.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAX_NAME_STACK_DEPTH = 0x0D37;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported depth of the projection matrix stack. The value must be at least 
		/// 2. See Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAX_PROJECTION_STACK_DEPTH = 0x0D38;

		/// <summary>
		/// Gl.Get: params returns one value, the maximum supported depth of the texture matrix stack. The value must be at least 2. 
		/// See Gl.PushMatrix.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAX_TEXTURE_STACK_DEPTH = 0x0D39;

		/// <summary>
		/// Gl.Get: params returns one value, the number of bitplanes in each color index buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int INDEX_BITS = 0x0D51;

		/// <summary>
		/// Gl.Get: params returns one value, the number of red bitplanes in each color buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int RED_BITS = 0x0D52;

		/// <summary>
		/// Gl.Get: params returns one value, the number of green bitplanes in each color buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int GREEN_BITS = 0x0D53;

		/// <summary>
		/// Gl.Get: params returns one value, the number of blue bitplanes in each color buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int BLUE_BITS = 0x0D54;

		/// <summary>
		/// Gl.Get: params returns one value, the number of alpha bitplanes in each color buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ALPHA_BITS = 0x0D55;

		/// <summary>
		/// Gl.Get: params returns one value, the number of bitplanes in the depth buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int DEPTH_BITS = 0x0D56;

		/// <summary>
		/// Gl.Get: params returns one value, the number of bitplanes in the stencil buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int STENCIL_BITS = 0x0D57;

		/// <summary>
		/// Gl.Get: params returns one value, the number of red bitplanes in the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ACCUM_RED_BITS = 0x0D58;

		/// <summary>
		/// Gl.Get: params returns one value, the number of green bitplanes in the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ACCUM_GREEN_BITS = 0x0D59;

		/// <summary>
		/// Gl.Get: params returns one value, the number of blue bitplanes in the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ACCUM_BLUE_BITS = 0x0D5A;

		/// <summary>
		/// Gl.Get: params returns one value, the number of alpha bitplanes in the accumulation buffer.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int ACCUM_ALPHA_BITS = 0x0D5B;

		/// <summary>
		/// Gl.Get: params returns one value, the number of names on the selection name stack. The initial value is 0. See 
		/// Gl.PushName.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int NAME_STACK_DEPTH = 0x0D70;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, generate normal vectors when either Gl.MAP2_VERTEX_3 or Gl.MAP2_VERTEX_4 is used to generate 
		/// vertices. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D map evaluation automatically generates surface 
		/// normals. The initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int AUTO_NORMAL = 0x0D80;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate RGBA values. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates colors. The initial value is 
		/// Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: Each control point is four floating-point values representing red, green, blue, and alpha. Internal Gl.Color4 
		/// commands are generated when the map is evaluated but the current color is not updated with the value of these Gl.Color4 
		/// commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP1_COLOR_4 = 0x0D90;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate color indices. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates color indices. The initial 
		/// value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: Each control point is a single floating-point value representing a color index. Internal Gl.Index commands are 
		/// generated when the map is evaluated but the current index is not updated with the value of these Gl.Index commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP1_INDEX = 0x0D91;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate normals. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates normals. The initial value is 
		/// Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: Each control point is three floating-point values representing the x, y, and z components of a normal vector. 
		/// Internal Gl.Normal commands are generated when the map is evaluated but the current normal is not updated with the value 
		/// of these Gl.Normal commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP1_NORMAL = 0x0D92;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate s texture coordinates. See 
		/// Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 1D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: Each control point is a single floating-point value representing the s texture coordinate. Internal 
		/// Gl.TexCoord1 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP1_TEXTURE_COORD_1 = 0x0D93;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate s and t texture coordinates. See 
		/// Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 2D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: Each control point is two floating-point values representing the s and t texture coordinates. Internal 
		/// Gl.TexCoord2 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP1_TEXTURE_COORD_2 = 0x0D94;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate s, t, and r texture coordinates. 
		/// See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 3D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: Each control point is three floating-point values representing the s, t, and r texture coordinates. Internal 
		/// Gl.TexCoord3 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP1_TEXTURE_COORD_3 = 0x0D95;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate s, t, r, and q texture 
		/// coordinates. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 4D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: Each control point is four floating-point values representing the s, t, r, and q texture coordinates. Internal 
		/// Gl.TexCoord4 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP1_TEXTURE_COORD_4 = 0x0D96;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate x, y, and z vertex coordinates. 
		/// See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 3D vertex coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: Each control point is three floating-point values representing x, y, and z. Internal Gl.Vertex3 commands are 
		/// generated when the map is evaluated.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP1_VERTEX_3 = 0x0D97;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord1, Gl.EvalMesh1, and Gl.EvalPoint1 generate homogeneous x, y, z, and w 
		/// vertex coordinates. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 1D evaluation generates 4D vertex coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map1.
		/// </para>
		/// <para>
		/// Gl.Map1: Each control point is four floating-point values representing x, y, z, and w. Internal Gl.Vertex4 commands are 
		/// generated when the map is evaluated.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP1_VERTEX_4 = 0x0D98;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate RGBA values. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates colors. The initial value is 
		/// Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: Each control point is four floating-point values representing red, green, blue, and alpha. Internal Gl.Color4 
		/// commands are generated when the map is evaluated but the current color is not updated with the value of these Gl.Color4 
		/// commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP2_COLOR_4 = 0x0DB0;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate color indices. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates color indices. The initial 
		/// value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: Each control point is a single floating-point value representing a color index. Internal Gl.Index commands are 
		/// generated when the map is evaluated but the current index is not updated with the value of these Gl.Index commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP2_INDEX = 0x0DB1;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate normals. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates normals. The initial value is 
		/// Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: Each control point is three floating-point values representing the x, y, and z components of a normal vector. 
		/// Internal Gl.Normal commands are generated when the map is evaluated but the current normal is not updated with the value 
		/// of these Gl.Normal commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP2_NORMAL = 0x0DB2;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate s texture coordinates. See 
		/// Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 1D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: Each control point is a single floating-point value representing the s texture coordinate. Internal 
		/// Gl.TexCoord1 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP2_TEXTURE_COORD_1 = 0x0DB3;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate s and t texture coordinates. See 
		/// Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 2D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: Each control point is two floating-point values representing the s and t texture coordinates. Internal 
		/// Gl.TexCoord2 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP2_TEXTURE_COORD_2 = 0x0DB4;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate s, t, and r texture coordinates. 
		/// See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 3D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: Each control point is three floating-point values representing the s, t, and r texture coordinates. Internal 
		/// Gl.TexCoord3 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP2_TEXTURE_COORD_3 = 0x0DB5;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate s, t, r, and q texture 
		/// coordinates. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 4D texture coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: Each control point is four floating-point values representing the s, t, r, and q texture coordinates. Internal 
		/// Gl.TexCoord4 commands are generated when the map is evaluated but the current texture coordinates are not updated with 
		/// the value of these Gl.TexCoord commands.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP2_TEXTURE_COORD_4 = 0x0DB6;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate x, y, and z vertex coordinates. 
		/// See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 3D vertex coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: Each control point is three floating-point values representing x, y, and z. Internal Gl.Vertex3 commands are 
		/// generated when the map is evaluated.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP2_VERTEX_3 = 0x0DB7;

		/// <summary>
		/// <para>
		/// Gl.Enable: If enabled, calls to Gl.EvalCoord2, Gl.EvalMesh2, and Gl.EvalPoint2 generate homogeneous x, y, z, and w 
		/// vertex coordinates. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Get: params returns a single boolean value indicating whether 2D evaluation generates 4D vertex coordinates. The 
		/// initial value is Gl.FALSE. See Gl.Map2.
		/// </para>
		/// <para>
		/// Gl.Map2: Each control point is four floating-point values representing x, y, z, and w. Internal Gl.Vertex4 commands are 
		/// generated when the map is evaluated.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP2_VERTEX_4 = 0x0DB8;

		/// <summary>
		/// Gl.Get: params returns two values: the endpoints of the 1D map's grid domain. The initial value is (0, 1). See 
		/// Gl.MapGrid.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP1_GRID_DOMAIN = 0x0DD0;

		/// <summary>
		/// Gl.Get: params returns one value, the number of partitions in the 1D map's grid domain. The initial value is 1. See 
		/// Gl.MapGrid.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP1_GRID_SEGMENTS = 0x0DD1;

		/// <summary>
		/// Gl.Get: params returns four values: the endpoints of the 2D map's i and j grid domains. The initial value is (0,1; 0,1). 
		/// See Gl.MapGrid.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP2_GRID_DOMAIN = 0x0DD2;

		/// <summary>
		/// Gl.Get: params returns two values: the number of partitions in the 2D map's i and j grid domains. The initial value is 
		/// (1,1). See Gl.MapGrid.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MAP2_GRID_SEGMENTS = 0x0DD3;

		/// <summary>
		/// Value of GL_TEXTURE_COMPONENTS symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_COMPONENTS = 0x1003;

		/// <summary>
		/// Gl.GetTexLevelParameter: params returns a single value, the width in pixels of the border of the texture image. The 
		/// initial value is 0.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_BORDER = 0x1005;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns four integer or floating-point values representing the ambient intensity of the light 
		/// source. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value is (0, 0, 0, 1).
		/// </para>
		/// <para>
		/// Gl.GetMaterial: params returns four integer or floating-point values representing the ambient reflectance of the 
		/// material. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value is (0.2, 0.2, 0.2, 1.0)
		/// </para>
		/// <para>
		/// Gl.Light: params contains four integer or floating-point values that specify the ambient RGBA intensity of the light. 
		/// Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most negative 
		/// representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point values 
		/// are clamped. The initial ambient light intensity is (0, 0, 0, 1).
		/// </para>
		/// <para>
		/// Gl.Material: params contains four integer or floating-point values that specify the ambient RGBA reflectance of the 
		/// material. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point 
		/// values are clamped. The initial ambient reflectance for both front- and back-facing materials is (0.2, 0.2, 0.2, 1.0).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int AMBIENT = 0x1200;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns four integer or floating-point values representing the diffuse intensity of the light 
		/// source. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value for Gl.LIGHT0 is (1, 1, 1, 1); for other lights, the initial value is (0, 0, 0, 0).
		/// </para>
		/// <para>
		/// Gl.GetMaterial: params returns four integer or floating-point values representing the diffuse reflectance of the 
		/// material. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value is (0.8, 0.8, 0.8, 1.0).
		/// </para>
		/// <para>
		/// Gl.Light: params contains four integer or floating-point values that specify the diffuse RGBA intensity of the light. 
		/// Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most negative 
		/// representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point values 
		/// are clamped. The initial value for Gl.LIGHT0 is (1, 1, 1, 1); for other lights, the initial value is (0, 0, 0, 1).
		/// </para>
		/// <para>
		/// Gl.Material: params contains four integer or floating-point values that specify the diffuse RGBA reflectance of the 
		/// material. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point 
		/// values are clamped. The initial diffuse reflectance for both front- and back-facing materials is (0.8, 0.8, 0.8, 1.0).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int DIFFUSE = 0x1201;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns four integer or floating-point values representing the specular intensity of the light 
		/// source. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value for Gl.LIGHT0 is (1, 1, 1, 1); for other lights, the initial value is (0, 0, 0, 0).
		/// </para>
		/// <para>
		/// Gl.GetMaterial: params returns four integer or floating-point values representing the specular reflectance of the 
		/// material. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value is (0, 0, 0, 1).
		/// </para>
		/// <para>
		/// Gl.Light: params contains four integer or floating-point values that specify the specular RGBA intensity of the light. 
		/// Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most negative 
		/// representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point values 
		/// are clamped. The initial value for Gl.LIGHT0 is (1, 1, 1, 1); for other lights, the initial value is (0, 0, 0, 1).
		/// </para>
		/// <para>
		/// Gl.Material: params contains four integer or floating-point values that specify the specular RGBA reflectance of the 
		/// material. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point 
		/// values are clamped. The initial specular reflectance for both front- and back-facing materials is (0, 0, 0, 1).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int SPECULAR = 0x1202;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns four integer or floating-point values representing the position of the light source. Integer 
		/// values, when requested, are computed by rounding the internal floating-point values to the nearest integer value. The 
		/// returned values are those maintained in eye coordinates. They will not be equal to the values specified using Gl.Light, 
		/// unless the modelview matrix was identity at the time Gl.Light was called. The initial value is (0, 0, 1, 0).
		/// </para>
		/// <para>
		/// Gl.Light: params contains four integer or floating-point values that specify the position of the light in homogeneous 
		/// object coordinates. Both integer and floating-point values are mapped directly. Neither integer nor floating-point 
		/// values are clamped. The position is transformed by the modelview matrix when glLight is called (just as if it were a 
		/// point), and it is stored in eye coordinates. If the w component of the position is 0, the light is treated as a 
		/// directional source. Diffuse and specular lighting calculations take the light's direction, but not its actual position, 
		/// into account, and attenuation is disabled. Otherwise, diffuse and specular lighting calculations are based on the actual 
		/// location of the light in eye coordinates, and attenuation is enabled. The initial position is (0, 0, 1, 0); thus, the 
		/// initial light source is directional, parallel to, and in the direction of the -z axis.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int POSITION = 0x1203;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns three integer or floating-point values representing the direction of the light source. 
		/// Integer values, when requested, are computed by rounding the internal floating-point values to the nearest integer 
		/// value. The returned values are those maintained in eye coordinates. They will not be equal to the values specified using 
		/// Gl.Light, unless the modelview matrix was identity at the time Gl.Light was called. Although spot direction is 
		/// normalized before being used in the lighting equation, the returned values are the transformed versions of the specified 
		/// values prior to normalization. The initial value is 00-1.
		/// </para>
		/// <para>
		/// Gl.Light: params contains three integer or floating-point values that specify the direction of the light in homogeneous 
		/// object coordinates. Both integer and floating-point values are mapped directly. Neither integer nor floating-point 
		/// values are clamped. The spot direction is transformed by the upper 3x3 of the modelview matrix when glLight is called, 
		/// and it is stored in eye coordinates. It is significant only when Gl.SPOT_CUTOFF is not 180, which it is initially. The 
		/// initial direction is 00-1.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int SPOT_DIRECTION = 0x1204;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns a single integer or floating-point value representing the spot exponent of the light. An 
		/// integer value, when requested, is computed by rounding the internal floating-point representation to the nearest 
		/// integer. The initial value is 0.
		/// </para>
		/// <para>
		/// Gl.Light: params is a single integer or floating-point value that specifies the intensity distribution of the light. 
		/// Integer and floating-point values are mapped directly. Only values in the range 0128 are accepted. Effective light 
		/// intensity is attenuated by the cosine of the angle between the direction of the light and the direction from the light 
		/// to the vertex being lighted, raised to the power of the spot exponent. Thus, higher spot exponents result in a more 
		/// focused light source, regardless of the spot cutoff angle (see Gl.SPOT_CUTOFF, next paragraph). The initial spot 
		/// exponent is 0, resulting in uniform light distribution.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int SPOT_EXPONENT = 0x1205;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns a single integer or floating-point value representing the spot cutoff angle of the light. An 
		/// integer value, when requested, is computed by rounding the internal floating-point representation to the nearest 
		/// integer. The initial value is 180.
		/// </para>
		/// <para>
		/// Gl.Light: params is a single integer or floating-point value that specifies the maximum spread angle of a light source. 
		/// Integer and floating-point values are mapped directly. Only values in the range 090 and the special value 180 are 
		/// accepted. If the angle between the direction of the light and the direction from the light to the vertex being lighted 
		/// is greater than the spot cutoff angle, the light is completely masked. Otherwise, its intensity is controlled by the 
		/// spot exponent and the attenuation factors. The initial spot cutoff is 180, resulting in uniform light distribution.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int SPOT_CUTOFF = 0x1206;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns a single integer or floating-point value representing the constant (not distance-related) 
		/// attenuation of the light. An integer value, when requested, is computed by rounding the internal floating-point 
		/// representation to the nearest integer. The initial value is 1.
		/// </para>
		/// <para>
		/// Gl.Light: 
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CONSTANT_ATTENUATION = 0x1207;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns a single integer or floating-point value representing the linear attenuation of the light. 
		/// An integer value, when requested, is computed by rounding the internal floating-point representation to the nearest 
		/// integer. The initial value is 0.
		/// </para>
		/// <para>
		/// Gl.Light: 
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LINEAR_ATTENUATION = 0x1208;

		/// <summary>
		/// <para>
		/// Gl.GetLight: params returns a single integer or floating-point value representing the quadratic attenuation of the 
		/// light. An integer value, when requested, is computed by rounding the internal floating-point representation to the 
		/// nearest integer. The initial value is 0.
		/// </para>
		/// <para>
		/// Gl.Light: params is a single integer or floating-point value that specifies one of the three light attenuation factors. 
		/// Integer and floating-point values are mapped directly. Only nonnegative values are accepted. If the light is positional, 
		/// rather than directional, its intensity is attenuated by the reciprocal of the sum of the constant factor, the linear 
		/// factor times the distance between the light and the vertex being lighted, and the quadratic factor times the square of 
		/// the same distance. The initial attenuation factors are (1, 0, 0), resulting in no attenuation.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int QUADRATIC_ATTENUATION = 0x1209;

		/// <summary>
		/// Gl.NewList: Commands are merely compiled.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COMPILE = 0x1300;

		/// <summary>
		/// Gl.NewList: Commands are executed as they are compiled into the display list.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COMPILE_AND_EXECUTE = 0x1301;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of unsigned bytes. Each pair of bytes specifies a single display-list name. 
		/// The value of the pair is computed as 256 times the unsigned value of the first byte plus the unsigned value of the 
		/// second byte.
		/// </summary>
		[AliasOf("GL_2_BYTES_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int _2_BYTES = 0x1407;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of unsigned bytes. Each triplet of bytes specifies a single display-list 
		/// name. The value of the triplet is computed as 65536 times the unsigned value of the first byte, plus 256 times the 
		/// unsigned value of the second byte, plus the unsigned value of the third byte.
		/// </summary>
		[AliasOf("GL_3_BYTES_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int _3_BYTES = 0x1408;

		/// <summary>
		/// Gl.CallLists: lists is treated as an array of unsigned bytes. Each quadruplet of bytes specifies a single display-list 
		/// name. The value of the quadruplet is computed as 16777216 times the unsigned value of the first byte, plus 65536 times 
		/// the unsigned value of the second byte, plus 256 times the unsigned value of the third byte, plus the unsigned value of 
		/// the fourth byte.
		/// </summary>
		[AliasOf("GL_4_BYTES_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int _4_BYTES = 0x1409;

		/// <summary>
		/// <para>
		/// Gl.GetMaterial: params returns four integer or floating-point values representing the emitted light intensity of the 
		/// material. Integer values, when requested, are linearly mapped from the internal floating-point representation such that 
		/// 1.0 maps to the most positive representable integer value, and -1.0 maps to the most negative representable integer 
		/// value. If the internal value is outside the range -11, the corresponding integer return value is undefined. The initial 
		/// value is (0, 0, 0, 1).
		/// </para>
		/// <para>
		/// Gl.Material: params contains four integer or floating-point values that specify the RGBA emitted light intensity of the 
		/// material. Integer values are mapped linearly such that the most positive representable value maps to 1.0, and the most 
		/// negative representable value maps to -1.0. Floating-point values are mapped directly. Neither integer nor floating-point 
		/// values are clamped. The initial emission intensity for both front- and back-facing materials is (0, 0, 0, 1).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int EMISSION = 0x1600;

		/// <summary>
		/// <para>
		/// Gl.GetMaterial: params returns one integer or floating-point value representing the specular exponent of the material. 
		/// Integer values, when requested, are computed by rounding the internal floating-point value to the nearest integer value. 
		/// The initial value is 0.
		/// </para>
		/// <para>
		/// Gl.Material: params is a single integer or floating-point value that specifies the RGBA specular exponent of the 
		/// material. Integer and floating-point values are mapped directly. Only values in the range 0128 are accepted. The initial 
		/// specular exponent for both front- and back-facing materials is 0.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int SHININESS = 0x1601;

		/// <summary>
		/// Gl.Material: Equivalent to calling glMaterial twice with the same parameter values, once with Gl.AMBIENT and once with 
		/// Gl.DIFFUSE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int AMBIENT_AND_DIFFUSE = 0x1602;

		/// <summary>
		/// <para>
		/// Gl.GetMaterial: params returns three integer or floating-point values representing the ambient, diffuse, and specular 
		/// indices of the material. These indices are used only for color index lighting. (All the other parameters are used only 
		/// for RGBA lighting.) Integer values, when requested, are computed by rounding the internal floating-point values to the 
		/// nearest integer values.
		/// </para>
		/// <para>
		/// Gl.Material: params contains three integer or floating-point values specifying the color indices for ambient, diffuse, 
		/// and specular lighting. These three values, and Gl.SHININESS, are the only material values used by the color index mode 
		/// lighting equation. Refer to the Gl.LightModel reference page for a discussion of color index lighting.
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COLOR_INDEXES = 0x1603;

		/// <summary>
		/// Gl.MatrixMode: Applies subsequent matrix operations to the modelview matrix stack.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MODELVIEW = 0x1700;

		/// <summary>
		/// Gl.MatrixMode: Applies subsequent matrix operations to the projection matrix stack.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int PROJECTION = 0x1701;

		/// <summary>
		/// <para>
		/// Gl.DrawPixels: Each pixel is a single value, a color index. It is converted to fixed-point format, with an unspecified 
		/// number of bits to the right of the binary point, regardless of the memory data type. Floating-point values convert to 
		/// true fixed-point values. Signed and unsigned integer data is converted with all fraction bits set to 0. Bitmap data 
		/// convert to either 0 or 1. Each fixed-point index is then shifted left by Gl.INDEX_SHIFT bits and added to 
		/// Gl.INDEX_OFFSET. If Gl.INDEX_SHIFT is negative, the shift is to the right. In either case, zero bits fill otherwise 
		/// unspecified bit locations in the result. If the GL is in RGBA mode, the resulting index is converted to an RGBA pixel 
		/// with the help of the Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A tables. If 
		/// the GL is in color index mode, and if Gl.MAP_COLOR is true, the index is replaced with the value that it references in 
		/// lookup table Gl.PIXEL_MAP_I_TO_I. Whether the lookup replacement of the index is done or not, the integer part of the 
		/// index is then ANDed with 2b-1, where b is the number of bits in a color index buffer. The GL then converts the resulting 
		/// indices or RGBA colors to fragments by attaching the current raster position z coordinate and texture coordinates to 
		/// each pixel, then assigning x and y window coordinates to the nth fragment such that xn=xr+n%widthyn=yr+nwidth where xryr 
		/// is the current raster position. These pixel fragments are then treated just like the fragments generated by rasterizing 
		/// points, lines, or polygons. Texture mapping, fog, and all the fragment operations are applied before the fragments are 
		/// written to the frame buffer.
		/// </para>
		/// <para>
		/// Gl.ReadPixels: Color indices are read from the color buffer selected by Gl.ReadBuffer. Each index is converted to fixed 
		/// point, shifted left or right depending on the value and sign of Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET. If 
		/// Gl.MAP_COLOR is Gl.TRUE, indices are replaced by their mappings in the table Gl.PIXEL_MAP_I_TO_I.
		/// </para>
		/// <para>
		/// Gl.TexImage1D: Each element is a single value, a color index. The GL converts it to fixed point (with an unspecified 
		/// number of zero bits to the right of the binary point), shifted left or right depending on the value and sign of 
		/// Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET (see Gl.PixelTransfer). The resulting index is converted to a set of color 
		/// components using the Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A tables, and 
		/// clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage2D: Each element is a single value, a color index. The GL converts it to fixed point (with an unspecified 
		/// number of zero bits to the right of the binary point), shifted left or right depending on the value and sign of 
		/// Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET (see Gl.PixelTransfer). The resulting index is converted to a set of color 
		/// components using the Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A tables, and 
		/// clamped to the range [0,1].
		/// </para>
		/// <para>
		/// Gl.TexImage3D: Each element is a single value, a color index. The GL converts it to fixed point (with an unspecified 
		/// number of zero bits to the right of the binary point), shifted left or right depending on the value and sign of 
		/// Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET (see Gl.PixelTransfer). The resulting index is converted to a set of color 
		/// components using the Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A tables, and 
		/// clamped to the range [0,1].
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int COLOR_INDEX = 0x1900;

		/// <summary>
		/// <para>
		/// Gl.DrawPixels: Each pixel is a single luminance component. This component is converted to the internal floating-point 
		/// format in the same way the red component of an RGBA pixel is. It is then converted to an RGBA pixel with red, green, and 
		/// blue set to the converted luminance value, and alpha set to 1. After this conversion, the pixel is treated as if it had 
		/// been read as an RGBA pixel.
		/// </para>
		/// <para>
		/// Gl.ReadPixels: 
		/// </para>
		/// <para>
		/// Gl.TexImage1D: Each element is a single luminance value. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the luminance value three times for red, green, and blue and attaching 1 for alpha. Each 
		/// component is then multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to 
		/// the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: Each element is a single luminance value. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the luminance value three times for red, green, and blue and attaching 1 for alpha. Each 
		/// component is then multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to 
		/// the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: Each element is a single luminance value. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the luminance value three times for red, green, and blue and attaching 1 for alpha. Each 
		/// component is then multiplied by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to 
		/// the range [0,1] (see Gl.PixelTransfer).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LUMINANCE = 0x1909;

		/// <summary>
		/// <para>
		/// Gl.DrawPixels: Each pixel is a two-component group: luminance first, followed by alpha. The two components are converted 
		/// to the internal floating-point format in the same way the red component of an RGBA pixel is. They are then converted to 
		/// an RGBA pixel with red, green, and blue set to the converted luminance value, and alpha set to the converted alpha 
		/// value. After this conversion, the pixel is treated as if it had been read as an RGBA pixel.
		/// </para>
		/// <para>
		/// Gl.ReadPixels: Processing differs depending on whether color buffers store color indices or RGBA color components. If 
		/// color indices are stored, they are read from the color buffer selected by Gl.ReadBuffer. Each index is converted to 
		/// fixed point, shifted left or right depending on the value and sign of Gl.INDEX_SHIFT, and added to Gl.INDEX_OFFSET. 
		/// Indices are then replaced by the red, green, blue, and alpha values obtained by indexing the tables Gl.PIXEL_MAP_I_TO_R, 
		/// Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, and Gl.PIXEL_MAP_I_TO_A. Each table must be of size 2n, but n may be different 
		/// for different tables. Before an index is used to look up a value in a table of size 2n, it must be masked against 2n-1. 
		/// If RGBA color components are stored in the color buffers, they are read from the color buffer selected by Gl.ReadBuffer. 
		/// Each color component is converted to floating point such that zero intensity maps to 0.0 and full intensity maps to 1.0. 
		/// Each component is then multiplied by Gl.c_SCALE and added to Gl.c_BIAS, where c is RED, GREEN, BLUE, or ALPHA. Finally, 
		/// if Gl.MAP_COLOR is Gl.TRUE, each component is clamped to the range 01, scaled to the size of its corresponding table, 
		/// and is then replaced by its mapping in the table Gl.PIXEL_MAP_c_TO_c, where c is R, G, B, or A. Unneeded data is then 
		/// discarded. For example, Gl.RED discards the green, blue, and alpha components, while Gl.RGB discards only the alpha 
		/// component. Gl.LUMINANCE computes a single-component value as the sum of the red, green, and blue components, and 
		/// Gl.LUMINANCE_ALPHA does the same, while keeping alpha as a second value. The final values are clamped to the range 01.
		/// </para>
		/// <para>
		/// Gl.TexImage1D: Each element is a luminance/alpha pair. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the luminance value three times for red, green, and blue. Each component is then multiplied 
		/// by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see 
		/// Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage2D: Each element is a luminance/alpha pair. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the luminance value three times for red, green, and blue. Each component is then multiplied 
		/// by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see 
		/// Gl.PixelTransfer).
		/// </para>
		/// <para>
		/// Gl.TexImage3D: Each element is a luminance/alpha pair. The GL converts it to floating point, then assembles it into an 
		/// RGBA element by replicating the luminance value three times for red, green, and blue. Each component is then multiplied 
		/// by the signed scale factor Gl.c_SCALE, added to the signed bias Gl.c_BIAS, and clamped to the range [0,1] (see 
		/// Gl.PixelTransfer).
		/// </para>
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LUMINANCE_ALPHA = 0x190A;

		/// <summary>
		/// Value of GL_BITMAP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int BITMAP = 0x1A00;

		/// <summary>
		/// Gl.RenderMode: Render mode. Primitives are rasterized, producing pixel fragments, which are written into the frame 
		/// buffer. This is the normal mode and also the default mode.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int RENDER = 0x1C00;

		/// <summary>
		/// Gl.RenderMode: Feedback mode. No pixel fragments are produced, and no change to the frame buffer contents is made. 
		/// Instead, the coordinates and attributes of vertices that would have been drawn if the render mode had been Gl.RENDER is 
		/// returned in a feedback buffer, which must be created (see Gl.FeedbackBuffer) before feedback mode is entered.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FEEDBACK = 0x1C01;

		/// <summary>
		/// Gl.RenderMode: Selection mode. No pixel fragments are produced, and no change to the frame buffer contents is made. 
		/// Instead, a record of the names of primitives that would have been drawn if the render mode had been Gl.RENDER is 
		/// returned in a select buffer, which must be created (see Gl.SelectBuffer) before selection mode is entered.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int SELECT = 0x1C02;

		/// <summary>
		/// Value of GL_FLAT symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int FLAT = 0x1D00;

		/// <summary>
		/// Value of GL_SMOOTH symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int SMOOTH = 0x1D01;

		/// <summary>
		/// Value of GL_S symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int S = 0x2000;

		/// <summary>
		/// Value of GL_T symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int T = 0x2001;

		/// <summary>
		/// Value of GL_R symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int R = 0x2002;

		/// <summary>
		/// Value of GL_Q symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int Q = 0x2003;

		/// <summary>
		/// Value of GL_MODULATE symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int MODULATE = 0x2100;

		/// <summary>
		/// Value of GL_DECAL symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int DECAL = 0x2101;

		/// <summary>
		/// Gl.GetTexEnv: params returns the single-valued texture environment mode, a symbolic constant. The initial value is 
		/// Gl.MODULATE.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_ENV_MODE = 0x2200;

		/// <summary>
		/// Gl.GetTexEnv: params returns four integer or floating-point values that are the texture environment color. Integer 
		/// values, when requested, are linearly mapped from the internal floating-point representation such that 1.0 maps to the 
		/// most positive representable integer, and -1.0 maps to the most negative representable integer. The initial value is (0, 
		/// 0, 0, 0).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_ENV_COLOR = 0x2201;

		/// <summary>
		/// Value of GL_TEXTURE_ENV symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_ENV = 0x2300;

		/// <summary>
		/// Value of GL_EYE_LINEAR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_EYE_LINEAR_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int EYE_LINEAR = 0x2400;

		/// <summary>
		/// Value of GL_OBJECT_LINEAR symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_OBJECT_LINEAR_NV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_path_rendering", Api = "gl|glcore|gles2")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int OBJECT_LINEAR = 0x2401;

		/// <summary>
		/// Value of GL_SPHERE_MAP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int SPHERE_MAP = 0x2402;

		/// <summary>
		/// Gl.GetTexGen: params returns the single-valued texture generation function, a symbolic constant. The initial value is 
		/// Gl.EYE_LINEAR.
		/// </summary>
		[AliasOf("GL_TEXTURE_GEN_MODE_OES")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_OES_texture_cube_map", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int TEXTURE_GEN_MODE = 0x2500;

		/// <summary>
		/// Gl.GetTexGen: params returns the four plane equation coefficients that specify object linear-coordinate generation. 
		/// Integer values, when requested, are mapped directly from the internal floating-point representation.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int OBJECT_PLANE = 0x2501;

		/// <summary>
		/// Gl.GetTexGen: params returns the four plane equation coefficients that specify eye linear-coordinate generation. Integer 
		/// values, when requested, are mapped directly from the internal floating-point representation. The returned values are 
		/// those maintained in eye coordinates. They are not equal to the values specified using Gl.TexGen, unless the modelview 
		/// matrix was identity when Gl.TexGen was called.
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_fog_distance")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int EYE_PLANE = 0x2502;

		/// <summary>
		/// Value of GL_CLAMP symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CLAMP = 0x2900;

		/// <summary>
		/// Value of GL_CLIP_PLANE0 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CLIP_PLANE0_IMG")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CLIP_PLANE0 = 0x3000;

		/// <summary>
		/// Value of GL_CLIP_PLANE1 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CLIP_PLANE1_IMG")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CLIP_PLANE1 = 0x3001;

		/// <summary>
		/// Value of GL_CLIP_PLANE2 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CLIP_PLANE2_IMG")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CLIP_PLANE2 = 0x3002;

		/// <summary>
		/// Value of GL_CLIP_PLANE3 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CLIP_PLANE3_IMG")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CLIP_PLANE3 = 0x3003;

		/// <summary>
		/// Value of GL_CLIP_PLANE4 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CLIP_PLANE4_IMG")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CLIP_PLANE4 = 0x3004;

		/// <summary>
		/// Value of GL_CLIP_PLANE5 symbol (DEPRECATED).
		/// </summary>
		[AliasOf("GL_CLIP_PLANE5_IMG")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_IMG_user_clip_plane", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int CLIP_PLANE5 = 0x3005;

		/// <summary>
		/// Value of GL_LIGHT0 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIGHT0 = 0x4000;

		/// <summary>
		/// Value of GL_LIGHT1 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIGHT1 = 0x4001;

		/// <summary>
		/// Value of GL_LIGHT2 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIGHT2 = 0x4002;

		/// <summary>
		/// Value of GL_LIGHT3 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIGHT3 = 0x4003;

		/// <summary>
		/// Value of GL_LIGHT4 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIGHT4 = 0x4004;

		/// <summary>
		/// Value of GL_LIGHT5 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIGHT5 = 0x4005;

		/// <summary>
		/// Value of GL_LIGHT6 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIGHT6 = 0x4006;

		/// <summary>
		/// Value of GL_LIGHT7 symbol (DEPRECATED).
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public const int LIGHT7 = 0x4007;

		/// <summary>
		/// specify whether front- or back-facing facets can be culled
		/// </summary>
		/// <param name="mode">
		/// Specifies whether front- or back-facing facets are candidates for culling. Symbolic constants Gl.FRONT, Gl.BACK, and 
		/// Gl.FRONT_AND_BACK are accepted. The initial value is Gl.BACK.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.FrontFace"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void CullFace(CullFaceMode mode)
		{
			Debug.Assert(Delegates.pglCullFace != null, "pglCullFace not implemented");
			Delegates.pglCullFace((Int32)mode);
			LogCommand("glCullFace", null, mode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define front- and back-facing polygons
		/// </summary>
		/// <param name="mode">
		/// Specifies the orientation of front-facing polygons. Gl.CW and Gl.CCW are accepted. The initial value is Gl.CCW.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.CullFace"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void FrontFace(FrontFaceDirection mode)
		{
			Debug.Assert(Delegates.pglFrontFace != null, "pglFrontFace not implemented");
			Delegates.pglFrontFace((Int32)mode);
			LogCommand("glFrontFace", null, mode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify implementation-specific hints
		/// </summary>
		/// <param name="target">
		/// Specifies a symbolic constant indicating the behavior to be controlled. Gl.LINE_SMOOTH_HINT, Gl.POLYGON_SMOOTH_HINT, 
		/// Gl.TEXTURE_COMPRESSION_HINT, and Gl.FRAGMENT_SHADER_DERIVATIVE_HINT are accepted.
		/// </param>
		/// <param name="mode">
		/// Specifies a symbolic constant indicating the desired behavior. Gl.FASTEST, Gl.NICEST, and Gl.DONT_CARE are accepted.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="target"/> or <paramref name="mode"/> is not an accepted value.
		/// </exception>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Hint(HintTarget target, HintMode mode)
		{
			Debug.Assert(Delegates.pglHint != null, "pglHint not implemented");
			Delegates.pglHint((Int32)target, (Int32)mode);
			LogCommand("glHint", null, target, mode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the width of rasterized lines
		/// </summary>
		/// <param name="width">
		/// Specifies the width of rasterized lines. The initial value is 1.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than or equal to 0.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void LineWidth(float width)
		{
			Debug.Assert(Delegates.pglLineWidth != null, "pglLineWidth not implemented");
			Delegates.pglLineWidth(width);
			LogCommand("glLineWidth", null, width			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the diameter of rasterized points
		/// </summary>
		/// <param name="size">
		/// Specifies the diameter of rasterized points. The initial value is 1.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is less than or equal to 0.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.PointParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void PointSize(float size)
		{
			Debug.Assert(Delegates.pglPointSize != null, "pglPointSize not implemented");
			Delegates.pglPointSize(size);
			LogCommand("glPointSize", null, size			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// select a polygon rasterization mode
		/// </summary>
		/// <param name="face">
		/// Specifies the polygons that <paramref name="mode"/> applies to. Must be Gl.FRONT_AND_BACK for front- and back-facing 
		/// polygons.
		/// </param>
		/// <param name="mode">
		/// Specifies how polygons will be rasterized. Accepted values are Gl.POINT, Gl.LINE, and Gl.FILL. The initial value is 
		/// Gl.FILL for both front- and back-facing polygons.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="face"/> or <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.PointSize"/>
		[AliasOf("glPolygonModeNV")]
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
		public static void PolygonMode(MaterialFace face, PolygonMode mode)
		{
			Debug.Assert(Delegates.pglPolygonMode != null, "pglPolygonMode not implemented");
			Delegates.pglPolygonMode((Int32)face, (Int32)mode);
			LogCommand("glPolygonMode", null, face, mode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define the scissor box
		/// </summary>
		/// <param name="x">
		/// Specify the lower left corner of the scissor box. Initially (0, 0).
		/// </param>
		/// <param name="y">
		/// Specify the lower left corner of the scissor box. Initially (0, 0).
		/// </param>
		/// <param name="width">
		/// Specify the width and height of the scissor box. When a GL context is first attached to a window, <paramref 
		/// name="width"/> and <paramref name="height"/> are set to the dimensions of that window.
		/// </param>
		/// <param name="height">
		/// Specify the width and height of the scissor box. When a GL context is first attached to a window, <paramref 
		/// name="width"/> and <paramref name="height"/> are set to the dimensions of that window.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglScissor != null, "pglScissor not implemented");
			Delegates.pglScissor(x, y, width, height);
			LogCommand("glScissor", null, x, y, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY, 
		/// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted defined 
		/// values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="params"/> should have a defined constant value (based on the value of 
		/// <paramref name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, float param)
		{
			Debug.Assert(Delegates.pglTexParameterf != null, "pglTexParameterf not implemented");
			Delegates.pglTexParameterf((Int32)target, (Int32)pname, param);
			LogCommand("glTexParameterf", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY, 
		/// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted defined 
		/// values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="params"/> should have a defined constant value (based on the value of 
		/// <paramref name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameterfv != null, "pglTexParameterfv not implemented");
					Delegates.pglTexParameterfv((Int32)target, (Int32)pname, p_params);
					LogCommand("glTexParameterfv", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY, 
		/// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
		/// </param>
		/// <param name="param">
		/// Specifies the value of <paramref name="pname"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted defined 
		/// values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="params"/> should have a defined constant value (based on the value of 
		/// <paramref name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexParameteri != null, "pglTexParameteri not implemented");
			Delegates.pglTexParameteri((Int32)target, (Int32)pname, param);
			LogCommand("glTexParameteri", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture, which must be either Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, or Gl.TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture parameter. <paramref name="pname"/> can be one of the following: 
		/// Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MAG_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_BASE_LEVEL, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, Gl.TEXTURE_WRAP_R, Gl.TEXTURE_PRIORITY, 
		/// Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, Gl.DEPTH_TEXTURE_MODE, or Gl.GENERATE_MIPMAP.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted defined 
		/// values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="params"/> should have a defined constant value (based on the value of 
		/// <paramref name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexParameter is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.BindTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PrioritizeTextures"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexParameteriv != null, "pglTexParameteriv not implemented");
					Delegates.pglTexParameteriv((Int32)target, (Int32)pname, p_params);
					LogCommand("glTexParameteriv", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a one-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// that are at least 64 texels wide. The height of the 1D texture image is 1.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN, 
		/// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant. Format constants other 
		/// than Gl.STENCIL_INDEX are accepted.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not 
		/// Gl.COLOR_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the accepted resolution 
		/// and format symbolic constants.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0 or greater than 2 + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if non-power-of-two textures are not supported and the <paramref name="width"/> cannot be 
		/// represented as 2n+2⁡border for some integer value of n.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0 or 1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.DEPTH_COMPONENT and <paramref 
		/// name="internalFormat"/> is not Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalFormat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32, and <paramref name="format"/> is not Gl.DEPTH_COMPONENT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexImage1D is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage1D != null, "pglTexImage1D not implemented");
			Delegates.pglTexImage1D((Int32)target, level, internalformat, width, border, (Int32)format, (Int32)type, pixels);
			LogCommand("glTexImage1D", null, target, level, internalformat, width, border, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a one-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// that are at least 64 texels wide. The height of the 1D texture image is 1.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN, 
		/// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_1D or Gl.PROXY_TEXTURE_1D.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> is not an accepted format constant. Format constants other 
		/// than Gl.STENCIL_INDEX are accepted.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not 
		/// Gl.COLOR_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the accepted resolution 
		/// and format symbolic constants.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> is less than 0 or greater than 2 + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if non-power-of-two textures are not supported and the <paramref name="width"/> cannot be 
		/// represented as 2n+2⁡border for some integer value of n.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0 or 1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.DEPTH_COMPONENT and <paramref 
		/// name="internalFormat"/> is not Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalFormat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32, and <paramref name="format"/> is not Gl.DEPTH_COMPONENT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexImage1D is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.CompressedTexImage1D"/>
		/// <seealso cref="Gl.CompressedTexSubImage1D"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void TexImage1D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage1D(target, level, internalformat, width, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify a two-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.PROXY_TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// that are at least 64 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support texture images 
		/// that are at least 64 texels high.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN, 
		/// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, 
		/// Gl.PROXY_TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is one of the six cube map 2D image targets and the width and 
		/// height parameters are not equal.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not 
		/// Gl.COLOR_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or greater than 2 
		/// + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the accepted resolution 
		/// and format symbolic constants.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or greater than 2 
		/// + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if non-power-of-two textures are not supported and the <paramref name="width"/> or 
		/// <paramref name="height"/> cannot be represented as 2k+2⁡border for some integer value of k.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0 or 1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="target"/> is not Gl.TEXTURE_2D or Gl.PROXY_TEXTURE_2D and <paramref 
		/// name="internalFormat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.DEPTH_COMPONENT and <paramref 
		/// name="internalFormat"/> is not Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalFormat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32, and <paramref name="format"/> is not Gl.DEPTH_COMPONENT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexImage2D is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void TexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglTexImage2D != null, "pglTexImage2D not implemented");
			Delegates.pglTexImage2D((Int32)target, level, internalformat, width, height, border, (Int32)format, (Int32)type, pixels);
			LogCommand("glTexImage2D", null, target, level, internalformat, width, height, border, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a two-dimensional texture image
		/// </summary>
		/// <param name="target">
		/// Specifies the target texture. Must be Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, or Gl.PROXY_TEXTURE_CUBE_MAP.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number. Level 0 is the base image level. Level n is the nth mipmap reduction image.
		/// </param>
		/// <param name="internalformat">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="width">
		/// Specifies the width of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2n+2⁡border for some integer n. All implementations support texture images 
		/// that are at least 64 texels wide.
		/// </param>
		/// <param name="height">
		/// Specifies the height of the texture image including the border if any. If the GL version does not support 
		/// non-power-of-two sizes, this value must be 2m+2⁡border for some integer m. All implementations support texture images 
		/// that are at least 64 texels high.
		/// </param>
		/// <param name="border">
		/// Specifies the width of the border. Must be either 0 or 1.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.RED, Gl.GREEN, 
		/// Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. The following symbolic values are accepted: Gl.UNSIGNED_BYTE, Gl.BYTE, 
		/// Gl.BITMAP, Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not Gl.TEXTURE_2D, Gl.PROXY_TEXTURE_2D, 
		/// Gl.PROXY_TEXTURE_CUBE_MAP, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, or 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is one of the six cube map 2D image targets and the width and 
		/// height parameters are not equal.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not a type constant.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not 
		/// Gl.COLOR_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or greater than 2 
		/// + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="internalFormat"/> is not 1, 2, 3, 4, or one of the accepted resolution 
		/// and format symbolic constants.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is less than 0 or greater than 2 
		/// + Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if non-power-of-two textures are not supported and the <paramref name="width"/> or 
		/// <paramref name="height"/> cannot be represented as 2k+2⁡border for some integer value of k.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="border"/> is not 0 or 1.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="target"/> is not Gl.TEXTURE_2D or Gl.PROXY_TEXTURE_2D and <paramref 
		/// name="internalFormat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.DEPTH_COMPONENT and <paramref 
		/// name="internalFormat"/> is not Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="internalFormat"/> is Gl.DEPTH_COMPONENT, Gl.DEPTH_COMPONENT16, 
		/// Gl.DEPTH_COMPONENT24, or Gl.DEPTH_COMPONENT32, and <paramref name="format"/> is not Gl.DEPTH_COMPONENT.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexImage2D is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void TexImage2D(TextureTarget target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				TexImage2D(target, level, internalformat, width, height, border, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// specify which color buffers are to be drawn into
		/// </summary>
		/// <param name="buf">
		/// For default framebuffer, the argument specifies up to four color buffers to be drawn into. Symbolic constants Gl.NONE, 
		/// Gl.FRONT_LEFT, Gl.FRONT_RIGHT, Gl.BACK_LEFT, Gl.BACK_RIGHT, Gl.FRONT, Gl.BACK, Gl.LEFT, Gl.RIGHT, and Gl.FRONT_AND_BACK 
		/// are accepted. The initial value is Gl.FRONT for single-buffered contexts, and Gl.BACK for double-buffered contexts. For 
		/// framebuffer objects, Gl.COLOR_ATTACHMENT$m$ and Gl.NONE enums are accepted, where Gl. is a value between 0 and 
		/// Gl.MAX_COLOR_ATTACHMENTS.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION error is generated by Gl.NamedFramebufferDrawBuffer if <paramref name="framebuffer"/> is not zero 
		/// or the name of an existing framebuffer object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="buf"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if the default framebuffer is affected and none of the buffers indicated by <paramref 
		/// name="buf"/> exists.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a framebuffer object is affected and <paramref name="buf"/> is not equal to Gl.NONE 
		/// or Gl.COLOR_ATTACHMENT$m$, where Gl. is a value between 0 and Gl.MAX_COLOR_ATTACHMENTS.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DrawBuffers"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void DrawBuffer(DrawBufferMode buf)
		{
			Debug.Assert(Delegates.pglDrawBuffer != null, "pglDrawBuffer not implemented");
			Delegates.pglDrawBuffer((Int32)buf);
			LogCommand("glDrawBuffer", null, buf			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// clear buffers to preset values
		/// </summary>
		/// <param name="mask">
		/// Bitwise OR of masks that indicate the buffers to be cleared. The three masks are Gl.COLOR_BUFFER_BIT, 
		/// Gl.DEPTH_BUFFER_BIT, and Gl.STENCIL_BUFFER_BIT.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if any bit other than the three defined bits is set in <paramref name="mask"/>.
		/// </exception>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilMask"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Clear(ClearBufferMask mask)
		{
			Debug.Assert(Delegates.pglClear != null, "pglClear not implemented");
			Delegates.pglClear((UInt32)mask);
			LogCommand("glClear", null, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify clear values for the color buffers
		/// </summary>
		/// <param name="red">
		/// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
		/// </param>
		/// <param name="green">
		/// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
		/// </param>
		/// <param name="blue">
		/// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
		/// </param>
		/// <param name="alpha">
		/// Specify the red, green, blue, and alpha values used when the color buffers are cleared. The initial values are all 0.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.removedTypes"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void ClearColor(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglClearColor != null, "pglClearColor not implemented");
			Delegates.pglClearColor(red, green, blue, alpha);
			LogCommand("glClearColor", null, red, green, blue, alpha			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the clear value for the stencil buffer
		/// </summary>
		/// <param name="s">
		/// Specifies the index used when the stencil buffer is cleared. The initial value is 0.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void ClearStencil(Int32 s)
		{
			Debug.Assert(Delegates.pglClearStencil != null, "pglClearStencil not implemented");
			Delegates.pglClearStencil(s);
			LogCommand("glClearStencil", null, s			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the clear value for the depth buffer
		/// </summary>
		/// <param name="depth">
		/// Specifies the depth value used when the depth buffer is cleared. The initial value is 1.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.removedTypes"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void ClearDepth(double depth)
		{
			Debug.Assert(Delegates.pglClearDepth != null, "pglClearDepth not implemented");
			Delegates.pglClearDepth(depth);
			LogCommand("glClearDepth", null, depth			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the front and back writing of individual bits in the stencil planes
		/// </summary>
		/// <param name="mask">
		/// Specifies a bit mask to enable and disable writing of individual bits in the stencil planes. Initially, the mask is all 
		/// 1's.
		/// </param>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void StencilMask(UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilMask != null, "pglStencilMask not implemented");
			Delegates.pglStencilMask(mask);
			LogCommand("glStencilMask", null, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// enable and disable writing of frame buffer color components
		/// </summary>
		/// <param name="red">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all Gl.TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <param name="green">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all Gl.TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <param name="blue">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all Gl.TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <param name="alpha">
		/// Specify whether red, green, blue, and alpha are to be written into the frame buffer. The initial values are all Gl.TRUE, 
		/// indicating that the color components are written.
		/// </param>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.StencilMask"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void ColorMask(bool red, bool green, bool blue, bool alpha)
		{
			Debug.Assert(Delegates.pglColorMask != null, "pglColorMask not implemented");
			Delegates.pglColorMask(red, green, blue, alpha);
			LogCommand("glColorMask", null, red, green, blue, alpha			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// enable or disable writing into the depth buffer
		/// </summary>
		/// <param name="flag">
		/// Specifies whether the depth buffer is enabled for writing. If <paramref name="flag"/> is Gl.FALSE, depth buffer writing 
		/// is disabled. Otherwise, it is enabled. Initially, depth buffer writing is enabled.
		/// </param>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.StencilMask"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void DepthMask(bool flag)
		{
			Debug.Assert(Delegates.pglDepthMask != null, "pglDepthMask not implemented");
			Delegates.pglDepthMask(flag);
			LogCommand("glDepthMask", null, flag			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// enable or disable server-side GL capabilities
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not one of the values listed previously.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Enable or Gl\.Disable is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ClipPlane"/>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.CullFace"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.Fog"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.LineStipple"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PointSize"/>
		/// <seealso cref="Gl.PolygonMode"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.SampleCoverage"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Disable(EnableCap cap)
		{
			Debug.Assert(Delegates.pglDisable != null, "pglDisable not implemented");
			Delegates.pglDisable((Int32)cap);
			LogCommand("glDisable", null, cap			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// enable or disable server-side GL capabilities
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not one of the values listed previously.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Enable or Gl\.Disable is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.ClipPlane"/>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.CullFace"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.EnableClientState"/>
		/// <seealso cref="Gl.Fog"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.LineStipple"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.PointSize"/>
		/// <seealso cref="Gl.PolygonMode"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.SampleCoverage"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Enable(EnableCap cap)
		{
			Debug.Assert(Delegates.pglEnable != null, "pglEnable not implemented");
			Delegates.pglEnable((Int32)cap);
			LogCommand("glEnable", null, cap			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// block until all GL execution is complete
		/// </summary>
		/// <seealso cref="Gl.Flush"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Finish()
		{
			Debug.Assert(Delegates.pglFinish != null, "pglFinish not implemented");
			Delegates.pglFinish();
			LogCommand("glFinish", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// force execution of GL commands in finite time
		/// </summary>
		/// <seealso cref="Gl.Finish"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Flush()
		{
			Debug.Assert(Delegates.pglFlush != null, "pglFlush not implemented");
			Delegates.pglFlush();
			LogCommand("glFlush", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify pixel arithmetic
		/// </summary>
		/// <param name="sfactor">
		/// Specifies how the red, green, blue, and alpha source blending factors are computed. The following symbolic constants are 
		/// accepted: Gl.ZERO, Gl.ONE, Gl.SRC_COLOR, Gl.ONE_MINUS_SRC_COLOR, Gl.DST_COLOR, Gl.ONE_MINUS_DST_COLOR, Gl.SRC_ALPHA, 
		/// Gl.ONE_MINUS_SRC_ALPHA, Gl.DST_ALPHA, Gl.ONE_MINUS_DST_ALPHA, Gl.CONSTANT_COLOR, Gl.ONE_MINUS_CONSTANT_COLOR, 
		/// Gl.CONSTANT_ALPHA, Gl.ONE_MINUS_CONSTANT_ALPHA, and Gl.SRC_ALPHA_SATURATE. The initial value is Gl.ONE.
		/// </param>
		/// <param name="dfactor">
		/// Specifies how the red, green, blue, and alpha destination blending factors are computed. The following symbolic 
		/// constants are accepted: Gl.ZERO, Gl.ONE, Gl.SRC_COLOR, Gl.ONE_MINUS_SRC_COLOR, Gl.DST_COLOR, Gl.ONE_MINUS_DST_COLOR, 
		/// Gl.SRC_ALPHA, Gl.ONE_MINUS_SRC_ALPHA, Gl.DST_ALPHA, Gl.ONE_MINUS_DST_ALPHA. Gl.CONSTANT_COLOR, 
		/// Gl.ONE_MINUS_CONSTANT_COLOR, Gl.CONSTANT_ALPHA, and Gl.ONE_MINUS_CONSTANT_ALPHA. The initial value is Gl.ZERO.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="sfactor"/> or <paramref name="dfactor"/> is not an accepted 
		/// value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.BlendFunc is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendColor"/>
		/// <seealso cref="Gl.BlendEquation"/>
		/// <seealso cref="Gl.BlendFuncSeparate"/>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void BlendFunc(BlendingFactorSrc sfactor, BlendingFactorDest dfactor)
		{
			Debug.Assert(Delegates.pglBlendFunc != null, "pglBlendFunc not implemented");
			Delegates.pglBlendFunc((Int32)sfactor, (Int32)dfactor);
			LogCommand("glBlendFunc", null, sfactor, dfactor			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a logical pixel operation for rendering
		/// </summary>
		/// <param name="opcode">
		/// Specifies a symbolic constant that selects a logical operation. The following symbols are accepted: Gl.CLEAR, Gl.SET, 
		/// Gl.COPY, Gl.COPY_INVERTED, Gl.NOOP, Gl.INVERT, Gl.AND, Gl.NAND, Gl.OR, Gl.NOR, Gl.XOR, Gl.EQUIV, Gl.AND_REVERSE, 
		/// Gl.AND_INVERTED, Gl.OR_REVERSE, and Gl.OR_INVERTED. The initial value is Gl.COPY.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="opcode"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.StencilOp"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		public static void LogicOp(LogicOp opcode)
		{
			Debug.Assert(Delegates.pglLogicOp != null, "pglLogicOp not implemented");
			Delegates.pglLogicOp((Int32)opcode);
			LogCommand("glLogicOp", null, opcode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set front and back function and reference value for stencil testing
		/// </summary>
		/// <param name="func">
		/// Specifies the test function. Eight symbolic constants are valid: Gl.NEVER, Gl.LESS, Gl.LEQUAL, Gl.GREATER, Gl.GEQUAL, 
		/// Gl.EQUAL, Gl.NOTEQUAL, and Gl.ALWAYS. The initial value is Gl.ALWAYS.
		/// </param>
		/// <param name="ref">
		/// Specifies the reference value for the stencil test. <paramref name="ref"/> is clamped to the range 02n-1, where n is the 
		/// number of bitplanes in the stencil buffer. The initial value is 0.
		/// </param>
		/// <param name="mask">
		/// Specifies a mask that is ANDed with both the reference value and the stored stencil value when the test is done. The 
		/// initial value is all 1's.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="func"/> is not one of the eight accepted values.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOp"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void StencilFunc(StencilFunction func, Int32 @ref, UInt32 mask)
		{
			Debug.Assert(Delegates.pglStencilFunc != null, "pglStencilFunc not implemented");
			Delegates.pglStencilFunc((Int32)func, @ref, mask);
			LogCommand("glStencilFunc", null, func, @ref, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set front and back stencil test actions
		/// </summary>
		/// <param name="sfail">
		/// Specifies the action to take when the stencil test fails. Eight symbolic constants are accepted: Gl.KEEP, Gl.ZERO, 
		/// Gl.REPLACE, Gl.INCR, Gl.INCR_WRAP, Gl.DECR, Gl.DECR_WRAP, and Gl.INVERT. The initial value is Gl.KEEP.
		/// </param>
		/// <param name="dpfail">
		/// Specifies the stencil action when the stencil test passes, but the depth test fails. <paramref name="dpfail"/> accepts 
		/// the same symbolic constants as <paramref name="sfail"/>. The initial value is Gl.KEEP.
		/// </param>
		/// <param name="dppass">
		/// Specifies the stencil action when both the stencil test and the depth test pass, or when the stencil test passes and 
		/// either there is no depth buffer or depth testing is not enabled. <paramref name="dppass"/> accepts the same symbolic 
		/// constants as <paramref name="sfail"/>. The initial value is Gl.KEEP.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="sfail"/>, <paramref name="dpfail"/>, or <paramref name="dppass"/> is any 
		/// value other than the defined constant values.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.StencilFuncSeparate"/>
		/// <seealso cref="Gl.StencilMask"/>
		/// <seealso cref="Gl.StencilMaskSeparate"/>
		/// <seealso cref="Gl.StencilOpSeparate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void StencilOp(StencilOp sfail, StencilOp dpfail, StencilOp dppass)
		{
			Debug.Assert(Delegates.pglStencilOp != null, "pglStencilOp not implemented");
			Delegates.pglStencilOp((Int32)sfail, (Int32)dpfail, (Int32)dppass);
			LogCommand("glStencilOp", null, sfail, dpfail, dppass			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the value used for depth buffer comparisons
		/// </summary>
		/// <param name="func">
		/// Specifies the depth comparison function. Symbolic constants Gl.NEVER, Gl.LESS, Gl.EQUAL, Gl.LEQUAL, Gl.GREATER, 
		/// Gl.NOTEQUAL, Gl.GEQUAL, and Gl.ALWAYS are accepted. The initial value is Gl.LESS.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="func"/> is not an accepted value.
		/// </exception>
		/// <seealso cref="Gl.DepthRange"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void DepthFunc(DepthFunction func)
		{
			Debug.Assert(Delegates.pglDepthFunc != null, "pglDepthFunc not implemented");
			Delegates.pglDepthFunc((Int32)func);
			LogCommand("glDepthFunc", null, func			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set pixel storage modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: 
		/// Gl.PACK_SWAP_BYTES, Gl.PACK_LSB_FIRST, Gl.PACK_ROW_LENGTH, Gl.PACK_IMAGE_HEIGHT, Gl.PACK_SKIP_PIXELS, Gl.PACK_SKIP_ROWS, 
		/// Gl.PACK_SKIP_IMAGES, and Gl.PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory: 
		/// Gl.UNPACK_SWAP_BYTES, Gl.UNPACK_LSB_FIRST, Gl.UNPACK_ROW_LENGTH, Gl.UNPACK_IMAGE_HEIGHT, Gl.UNPACK_SKIP_PIXELS, 
		/// Gl.UNPACK_SKIP_ROWS, Gl.UNPACK_SKIP_IMAGES, and Gl.UNPACK_ALIGNMENT.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a negative row length, pixel skip, or row skip value is specified, or if alignment is 
		/// specified as other than 1, 2, 4, or 8.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelStore is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void PixelStore(PixelStoreParameter pname, float param)
		{
			Debug.Assert(Delegates.pglPixelStoref != null, "pglPixelStoref not implemented");
			Delegates.pglPixelStoref((Int32)pname, param);
			LogCommand("glPixelStoref", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set pixel storage modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the parameter to be set. Six values affect the packing of pixel data into memory: 
		/// Gl.PACK_SWAP_BYTES, Gl.PACK_LSB_FIRST, Gl.PACK_ROW_LENGTH, Gl.PACK_IMAGE_HEIGHT, Gl.PACK_SKIP_PIXELS, Gl.PACK_SKIP_ROWS, 
		/// Gl.PACK_SKIP_IMAGES, and Gl.PACK_ALIGNMENT. Six more affect the unpacking of pixel data from memory: 
		/// Gl.UNPACK_SWAP_BYTES, Gl.UNPACK_LSB_FIRST, Gl.UNPACK_ROW_LENGTH, Gl.UNPACK_IMAGE_HEIGHT, Gl.UNPACK_SKIP_PIXELS, 
		/// Gl.UNPACK_SKIP_ROWS, Gl.UNPACK_SKIP_IMAGES, and Gl.UNPACK_ALIGNMENT.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a negative row length, pixel skip, or row skip value is specified, or if alignment is 
		/// specified as other than 1, 2, 4, or 8.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelStore is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void PixelStore(PixelStoreParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelStorei != null, "pglPixelStorei not implemented");
			Delegates.pglPixelStorei((Int32)pname, param);
			LogCommand("glPixelStorei", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// select a color buffer source for pixels
		/// </summary>
		/// <param name="mode">
		/// Specifies a color buffer. Accepted values are Gl.FRONT_LEFT, Gl.FRONT_RIGHT, Gl.BACK_LEFT, Gl.BACK_RIGHT, Gl.FRONT, 
		/// Gl.BACK, Gl.LEFT, Gl.RIGHT, and the constants Gl.COLOR_ATTACHMENTi.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of the twelve (or more) accepted values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="mode"/> specifies a buffer that does not exist.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.NamedFramebufferReadBuffer if <paramref name="framebuffer"/> is not zero or the 
		/// name of an existing framebuffer object.
		/// </exception>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
		public static void ReadBuffer(ReadBufferMode mode)
		{
			Debug.Assert(Delegates.pglReadBuffer != null, "pglReadBuffer not implemented");
			Delegates.pglReadBuffer((Int32)mode);
			LogCommand("glReadBuffer", null, mode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// read a block of pixels from the frame buffer
		/// </summary>
		/// <param name="x">
		/// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left 
		/// corner of a rectangular block of pixels.
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the first pixel that is read from the frame buffer. This location is the lower left 
		/// corner of a rectangular block of pixels.
		/// </param>
		/// <param name="width">
		/// Specify the dimensions of the pixel rectangle. <paramref name="width"/> and <paramref name="height"/> of one correspond 
		/// to a single pixel.
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the pixel rectangle. <paramref name="width"/> and <paramref name="height"/> of one correspond 
		/// to a single pixel.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. The following symbolic values are accepted: Gl.COLOR_INDEX, Gl.STENCIL_INDEX, 
		/// Gl.DEPTH_COMPONENT, Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and 
		/// Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies the data type of the pixel data. Must be one of Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, Gl.UNSIGNED_SHORT, 
		/// Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="data">
		/// Returns the pixel data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> or <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not Gl.COLOR_INDEX 
		/// or Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.COLOR_INDEX and the color buffers store RGBA color 
		/// components.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and there is no stencil buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.DEPTH_COMPONENT and there is no depth buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// The formats Gl.BGR, and Gl.BGRA and types Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, 
		/// Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, 
		/// Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, and 
		/// Gl.UNSIGNED_INT_2_10_10_10_REV are available only if the GL version is 1.2 or greater.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ReadPixels is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr data)
		{
			Debug.Assert(Delegates.pglReadPixels != null, "pglReadPixels not implemented");
			Delegates.pglReadPixels(x, y, width, height, (Int32)format, (Int32)type, data);
			LogCommand("glReadPixels", null, x, y, width, height, format, type, data			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(Int32 pname, [Out] bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv(pname, p_data);
					LogCommand("glGetBooleanv", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(GetPName pname, [Out] bool[] data)
		{
			unsafe {
				fixed (bool* p_data = data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv((Int32)pname, p_data);
					LogCommand("glGetBooleanv", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(Int32 pname, out bool data)
		{
			unsafe {
				fixed (bool* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv(pname, p_data);
					LogCommand("glGetBooleanv", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(GetPName pname, out bool data)
		{
			unsafe {
				fixed (bool* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetBooleanv != null, "pglGetBooleanv not implemented");
					Delegates.pglGetBooleanv((Int32)pname, p_data);
					LogCommand("glGetBooleanv", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(Int32 pname, [Out] double[] data)
		{
			unsafe {
				fixed (double* p_data = data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev(pname, p_data);
					LogCommand("glGetDoublev", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(GetPName pname, [Out] double[] data)
		{
			unsafe {
				fixed (double* p_data = data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev((Int32)pname, p_data);
					LogCommand("glGetDoublev", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(Int32 pname, out double data)
		{
			unsafe {
				fixed (double* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev(pname, p_data);
					LogCommand("glGetDoublev", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void Get(GetPName pname, out double data)
		{
			unsafe {
				fixed (double* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetDoublev != null, "pglGetDoublev not implemented");
					Delegates.pglGetDoublev((Int32)pname, p_data);
					LogCommand("glGetDoublev", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return error information
		/// </summary>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static ErrorCode GetError()
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglGetError != null, "pglGetError not implemented");
			retValue = Delegates.pglGetError();
			LogCommand("glGetError", (ErrorCode)retValue			);

			return ((ErrorCode)retValue);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(Int32 pname, [Out] float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv(pname, p_data);
					LogCommand("glGetFloatv", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(GetPName pname, [Out] float[] data)
		{
			unsafe {
				fixed (float* p_data = data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv((Int32)pname, p_data);
					LogCommand("glGetFloatv", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(Int32 pname, out float data)
		{
			unsafe {
				fixed (float* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv(pname, p_data);
					LogCommand("glGetFloatv", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(GetPName pname, out float data)
		{
			unsafe {
				fixed (float* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetFloatv != null, "pglGetFloatv not implemented");
					Delegates.pglGetFloatv((Int32)pname, p_data);
					LogCommand("glGetFloatv", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(Int32 pname, [Out] Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv(pname, p_data);
					LogCommand("glGetIntegerv", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(GetPName pname, [Out] Int32[] data)
		{
			unsafe {
				fixed (Int32* p_data = data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv((Int32)pname, p_data);
					LogCommand("glGetIntegerv", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(Int32 pname, out Int32 data)
		{
			unsafe {
				fixed (Int32* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv(pname, p_data);
					LogCommand("glGetIntegerv", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the value or values of a selected parameter
		/// </summary>
		/// <param name="pname">
		/// Specifies the parameter value to be returned for non-indexed versions of Gl.Get. The symbolic constants in the list 
		/// below are accepted.
		/// </param>
		/// <param name="data">
		/// Returns the value or values of the specified parameter.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated on any of Gl.GetBooleani_v, Gl.GetIntegeri_v, or Gl.GetInteger64i_v if <paramref 
		/// name="index"/> is outside of the valid range for the indexed state <paramref name="target"/>.
		/// </exception>
		/// <seealso cref="Gl.GetActiveUniform"/>
		/// <seealso cref="Gl.GetAttachedShaders"/>
		/// <seealso cref="Gl.GetAttribLocation"/>
		/// <seealso cref="Gl.GetBufferParameter"/>
		/// <seealso cref="Gl.GetBufferPointerv"/>
		/// <seealso cref="Gl.GetBufferSubData"/>
		/// <seealso cref="Gl.GetCompressedTexImage"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetProgram"/>
		/// <seealso cref="Gl.GetProgramInfoLog"/>
		/// <seealso cref="Gl.GetQueryiv"/>
		/// <seealso cref="Gl.GetQueryObject"/>
		/// <seealso cref="Gl.GetShader"/>
		/// <seealso cref="Gl.GetShaderInfoLog"/>
		/// <seealso cref="Gl.GetShaderSource"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.GetUniform"/>
		/// <seealso cref="Gl.GetUniformLocation"/>
		/// <seealso cref="Gl.GetVertexAttrib"/>
		/// <seealso cref="Gl.GetVertexAttribPointerv"/>
		/// <seealso cref="Gl.IsEnabled"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Get(GetPName pname, out Int32 data)
		{
			unsafe {
				fixed (Int32* p_data = &data)
				{
					Debug.Assert(Delegates.pglGetIntegerv != null, "pglGetIntegerv not implemented");
					Delegates.pglGetIntegerv((Int32)pname, p_data);
					LogCommand("glGetIntegerv", null, pname, data					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return a string describing the current GL connection
		/// </summary>
		/// <param name="name">
		/// Specifies a symbolic constant, one of Gl.VENDOR, Gl.RENDERER, Gl.VERSION, or Gl.SHADING_LANGUAGE_VERSION. Additionally, 
		/// Gl.GetStringi accepts the Gl.EXTENSIONS token.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="name"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated by Gl.GetStringi if <paramref name="index"/> is outside the valid range for indexed state 
		/// <paramref name="name"/>.
		/// </exception>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static String GetString(StringName name)
		{
			IntPtr retValue;

			Debug.Assert(Delegates.pglGetString != null, "pglGetString not implemented");
			retValue = Delegates.pglGetString((Int32)name);
			LogCommand("glGetString", Marshal.PtrToStringAnsi(retValue), name			);
			DebugCheckErrors(retValue);

			return (Marshal.PtrToStringAnsi(retValue));
		}

		/// <summary>
		/// return a texture image
		/// </summary>
		/// <param name="target">
		/// Specifies which texture is to be obtained. Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, and Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z are accepted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="format">
		/// Specifies a pixel format for the returned data. The supported formats are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, 
		/// Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies a pixel type for the returned data. The supported types are Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.UNSIGNED_SHORT, 
		/// Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/>, <paramref name="format"/>, or <paramref name="type"/> is not 
		/// an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is returned if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is returned if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV, and <paramref 
		/// name="format"/> is neither Gl.RGBA or Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="img"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexImage is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglGetTexImage != null, "pglGetTexImage not implemented");
			Delegates.pglGetTexImage((Int32)target, level, (Int32)format, (Int32)type, pixels);
			LogCommand("glGetTexImage", null, target, level, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return a texture image
		/// </summary>
		/// <param name="target">
		/// Specifies which texture is to be obtained. Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP_POSITIVE_X, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, and Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z are accepted.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="format">
		/// Specifies a pixel format for the returned data. The supported formats are Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, 
		/// Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA.
		/// </param>
		/// <param name="type">
		/// Specifies a pixel type for the returned data. The supported types are Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.UNSIGNED_SHORT, 
		/// Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/>, <paramref name="format"/>, or <paramref name="type"/> is not 
		/// an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2⁡max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is returned if <paramref name="type"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is returned if <paramref name="type"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV, and <paramref 
		/// name="format"/> is neither Gl.RGBA or Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and 
		/// <paramref name="img"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexImage is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void GetTexImage(TextureTarget target, Int32 level, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				GetTexImage(target, level, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv, 
		/// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, 
		/// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, 
		/// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R, 
		/// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET, 
		/// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS, 
		/// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTexParameter if the effective <paramref name="target"/> is not one of the 
		/// accepted texture targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureParameter* if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameterfv != null, "pglGetTexParameterfv not implemented");
					Delegates.pglGetTexParameterfv((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetTexParameterfv", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetTexParameterfv, Gl.GetTexParameteriv, 
		/// Gl.GetTexParameterIiv, and Gl.GetTexParameterIuiv functions. Gl.TEXTURE_1D, Gl.TEXTURE_1D_ARRAY, Gl.TEXTURE_2D, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, Gl.TEXTURE_3D, Gl.TEXTURE_CUBE_MAP, 
		/// Gl.TEXTURE_RECTANGLE, and Gl.TEXTURE_CUBE_MAP_ARRAY are accepted.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.DEPTH_STENCIL_TEXTURE_MODE, Gl.IMAGE_FORMAT_COMPATIBILITY_TYPE, 
		/// Gl.TEXTURE_BASE_LEVEL, Gl.TEXTURE_BORDER_COLOR, Gl.TEXTURE_COMPARE_MODE, Gl.TEXTURE_COMPARE_FUNC, 
		/// Gl.TEXTURE_IMMUTABLE_FORMAT, Gl.TEXTURE_IMMUTABLE_LEVELS, Gl.TEXTURE_LOD_BIAS, Gl.TEXTURE_MAG_FILTER, 
		/// Gl.TEXTURE_MAX_LEVEL, Gl.TEXTURE_MAX_LOD, Gl.TEXTURE_MIN_FILTER, Gl.TEXTURE_MIN_LOD, Gl.TEXTURE_SWIZZLE_R, 
		/// Gl.TEXTURE_SWIZZLE_G, Gl.TEXTURE_SWIZZLE_B, Gl.TEXTURE_SWIZZLE_A, Gl.TEXTURE_SWIZZLE_RGBA, Gl.TEXTURE_TARGET, 
		/// Gl.TEXTURE_VIEW_MIN_LAYER, Gl.TEXTURE_VIEW_MIN_LEVEL, Gl.TEXTURE_VIEW_NUM_LAYERS, Gl.TEXTURE_VIEW_NUM_LEVELS, 
		/// Gl.TEXTURE_WRAP_S, Gl.TEXTURE_WRAP_T, and Gl.TEXTURE_WRAP_R are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the texture parameters.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM error is generated by Gl.GetTexParameter if the effective <paramref name="target"/> is not one of the 
		/// accepted texture targets.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureParameter* if <paramref name="texture"/> is not the name of an 
		/// existing texture object.
		/// </exception>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexStorage1D"/>
		/// <seealso cref="Gl.TexStorage2D"/>
		/// <seealso cref="Gl.TexStorage3D"/>
		/// <seealso cref="Gl.TextureView"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void GetTexParameter(TextureTarget target, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexParameteriv != null, "pglGetTexParameteriv not implemented");
					Delegates.pglGetTexParameteriv((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetTexParameteriv", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv 
		/// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D, 
		/// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY, 
		/// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH, 
		/// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE, 
		/// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureLevelParameterfv and Gl.GetTextureLevelParameteriv functions if 
		/// <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv functions if <paramref 
		/// name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is Gl.TEXTURE_BUFFER and <paramref name="level"/> is not 
		/// zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		/// internal format or on proxy targets.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		public static void GetTexLevelParameter(TextureTarget target, Int32 level, GetTextureParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameterfv != null, "pglGetTexLevelParameterfv not implemented");
					Delegates.pglGetTexLevelParameterfv((Int32)target, level, (Int32)pname, p_params);
					LogCommand("glGetTexLevelParameterfv", null, target, level, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv 
		/// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D, 
		/// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY, 
		/// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH, 
		/// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE, 
		/// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureLevelParameterfv and Gl.GetTextureLevelParameteriv functions if 
		/// <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv functions if <paramref 
		/// name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is Gl.TEXTURE_BUFFER and <paramref name="level"/> is not 
		/// zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		/// internal format or on proxy targets.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		public static void GetTexLevelParameter(TextureTarget target, Int32 level, GetTextureParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameteriv != null, "pglGetTexLevelParameteriv not implemented");
					Delegates.pglGetTexLevelParameteriv((Int32)target, level, (Int32)pname, p_params);
					LogCommand("glGetTexLevelParameteriv", null, target, level, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture parameter values for a specific level of detail
		/// </summary>
		/// <param name="target">
		/// Specifies the target to which the texture is bound for Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv 
		/// functions. Must be one of the following values: Gl.TEXTURE_1D, Gl.TEXTURE_2D, Gl.TEXTURE_3D, Gl.TEXTURE_1D_ARRAY, 
		/// Gl.TEXTURE_2D_ARRAY, Gl.TEXTURE_RECTANGLE, Gl.TEXTURE_2D_MULTISAMPLE, Gl.TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.TEXTURE_CUBE_MAP_POSITIVE_X, Gl.TEXTURE_CUBE_MAP_NEGATIVE_X, Gl.TEXTURE_CUBE_MAP_POSITIVE_Y, 
		/// Gl.TEXTURE_CUBE_MAP_NEGATIVE_Y, Gl.TEXTURE_CUBE_MAP_POSITIVE_Z, Gl.TEXTURE_CUBE_MAP_NEGATIVE_Z, Gl.PROXY_TEXTURE_1D, 
		/// Gl.PROXY_TEXTURE_2D, Gl.PROXY_TEXTURE_3D, Gl.PROXY_TEXTURE_1D_ARRAY, Gl.PROXY_TEXTURE_2D_ARRAY, 
		/// Gl.PROXY_TEXTURE_RECTANGLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE, Gl.PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY, 
		/// Gl.PROXY_TEXTURE_CUBE_MAP, or Gl.TEXTURE_BUFFER.
		/// </param>
		/// <param name="level">
		/// Specifies the level-of-detail number of the desired image. Level 0 is the base image level. Level n is the nth mipmap 
		/// reduction image.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture parameter. Gl.TEXTURE_WIDTH, Gl.TEXTURE_HEIGHT, Gl.TEXTURE_DEPTH, 
		/// Gl.TEXTURE_INTERNAL_FORMAT, Gl.TEXTURE_RED_SIZE, Gl.TEXTURE_GREEN_SIZE, Gl.TEXTURE_BLUE_SIZE, Gl.TEXTURE_ALPHA_SIZE, 
		/// Gl.TEXTURE_DEPTH_SIZE, Gl.TEXTURE_COMPRESSED, Gl.TEXTURE_COMPRESSED_IMAGE_SIZE, and Gl.TEXTURE_BUFFER_OFFSET are 
		/// accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetTextureLevelParameterfv and Gl.GetTextureLevelParameteriv functions if 
		/// <paramref name="texture"/> is not the name of an existing texture object.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated by Gl.GetTexLevelParameterfv and Gl.GetTexLevelParameteriv functions if <paramref 
		/// name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="level"/> is less than 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE may be generated if <paramref name="level"/> is greater than log2max, where max is the returned value 
		/// of Gl.MAX_TEXTURE_SIZE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="target"/> is Gl.TEXTURE_BUFFER and <paramref name="level"/> is not 
		/// zero.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TEXTURE_COMPRESSED_IMAGE_SIZE is queried on texture images with an uncompressed 
		/// internal format or on proxy targets.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
		public static void GetTexLevelParameter(TextureTarget target, Int32 level, GetTextureParameter pname, out Int32 @params)
		{
			unsafe {
				fixed (Int32* p_params = &@params)
				{
					Debug.Assert(Delegates.pglGetTexLevelParameteriv != null, "pglGetTexLevelParameteriv not implemented");
					Delegates.pglGetTexLevelParameteriv((Int32)target, level, (Int32)pname, p_params);
					LogCommand("glGetTexLevelParameteriv", null, target, level, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// test whether a capability is enabled
		/// </summary>
		/// <param name="cap">
		/// Specifies a symbolic constant indicating a GL capability.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="cap"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated by Gl.IsEnabledi if <paramref name="index"/> is outside the valid range for the indexed 
		/// state <paramref name="cap"/>.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Get"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static bool IsEnabled(EnableCap cap)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsEnabled != null, "pglIsEnabled not implemented");
			retValue = Delegates.pglIsEnabled((Int32)cap);
			LogCommand("glIsEnabled", retValue, cap			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// specify mapping of depth values from normalized device coordinates to window coordinates
		/// </summary>
		/// <param name="nearVal">
		/// Specifies the mapping of the near clipping plane to window coordinates. The initial value is 0.
		/// </param>
		/// <param name="farVal">
		/// Specifies the mapping of the far clipping plane to window coordinates. The initial value is 1.
		/// </param>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.PolygonOffset"/>
		/// <seealso cref="Gl.Viewport"/>
		/// <seealso cref="Gl.removedTypes"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		public static void DepthRange(double nearVal, double farVal)
		{
			Debug.Assert(Delegates.pglDepthRange != null, "pglDepthRange not implemented");
			Delegates.pglDepthRange(nearVal, farVal);
			LogCommand("glDepthRange", null, nearVal, farVal			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the viewport
		/// </summary>
		/// <param name="x">
		/// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
		/// </param>
		/// <param name="y">
		/// Specify the lower left corner of the viewport rectangle, in pixels. The initial value is (0,0).
		/// </param>
		/// <param name="width">
		/// Specify the width and height of the viewport. When a GL context is first attached to a window, <paramref name="width"/> 
		/// and <paramref name="height"/> are set to the dimensions of that window.
		/// </param>
		/// <param name="height">
		/// Specify the width and height of the viewport. When a GL context is first attached to a window, <paramref name="width"/> 
		/// and <paramref name="height"/> are set to the dimensions of that window.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Viewport is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.DepthRange"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
		public static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height)
		{
			Debug.Assert(Delegates.pglViewport != null, "pglViewport not implemented");
			Delegates.pglViewport(x, y, width, height);
			LogCommand("glViewport", null, x, y, width, height			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create or replace a display list
		/// </summary>
		/// <param name="list">
		/// Specifies the display-list name.
		/// </param>
		/// <param name="mode">
		/// Specifies the compilation mode, which can be Gl.COMPILE or Gl.COMPILE_AND_EXECUTE.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="list"/> is 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl\.EndList is called without a preceding Gl.NewList, or if Gl.NewList is called 
		/// while a display list is being defined.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.NewList or Gl\.EndList is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.OUT_OF_MEMORY is generated if there is insufficient memory to compile the display list. If the GL version is 1.1 or 
		/// greater, no change is made to the previous contents of the display list, if any, and no other change is made to the GL 
		/// state. (It is as if no attempt had been made to create the new display list.)
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.GenLists"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void NewList(UInt32 list, ListMode mode)
		{
			Debug.Assert(Delegates.pglNewList != null, "pglNewList not implemented");
			Delegates.pglNewList(list, (Int32)mode);
			LogCommand("glNewList", null, list, mode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// create or replace a display list
		/// </summary>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="list"/> is 0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl\.EndList is called without a preceding Gl.NewList, or if Gl.NewList is called 
		/// while a display list is being defined.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.NewList or Gl\.EndList is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.OUT_OF_MEMORY is generated if there is insufficient memory to compile the display list. If the GL version is 1.1 or 
		/// greater, no change is made to the previous contents of the display list, if any, and no other change is made to the GL 
		/// state. (It is as if no attempt had been made to create the new display list.)
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.GenLists"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EndList()
		{
			Debug.Assert(Delegates.pglEndList != null, "pglEndList not implemented");
			Delegates.pglEndList();
			LogCommand("glEndList", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// execute a display list
		/// </summary>
		/// <param name="list">
		/// Specifies the integer name of the display list to be executed.
		/// </param>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.GenLists"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PushAttrib"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CallList(UInt32 list)
		{
			Debug.Assert(Delegates.pglCallList != null, "pglCallList not implemented");
			Delegates.pglCallList(list);
			LogCommand("glCallList", null, list			);
		}

		/// <summary>
		/// execute a list of display lists
		/// </summary>
		/// <param name="n">
		/// Specifies the number of display lists to be executed.
		/// </param>
		/// <param name="type">
		/// Specifies the type of values in <paramref name="lists"/>. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, Gl.2_BYTES, Gl.3_BYTES, and Gl.4_BYTES are accepted.
		/// </param>
		/// <param name="lists">
		/// Specifies the address of an array of name offsets in the display list. The pointer type is void because the offsets can 
		/// be bytes, shorts, ints, or floats, depending on the value of <paramref name="type"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, Gl.2_BYTES, Gl.3_BYTES, Gl.4_BYTES.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.GenLists"/>
		/// <seealso cref="Gl.ListBase"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PushAttrib"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CallLists(Int32 n, ListNameType type, IntPtr lists)
		{
			Debug.Assert(Delegates.pglCallLists != null, "pglCallLists not implemented");
			Delegates.pglCallLists(n, (Int32)type, lists);
			LogCommand("glCallLists", null, n, type, lists			);
		}

		/// <summary>
		/// execute a list of display lists
		/// </summary>
		/// <param name="n">
		/// Specifies the number of display lists to be executed.
		/// </param>
		/// <param name="type">
		/// Specifies the type of values in <paramref name="lists"/>. Symbolic constants Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, Gl.2_BYTES, Gl.3_BYTES, and Gl.4_BYTES are accepted.
		/// </param>
		/// <param name="lists">
		/// Specifies the address of an array of name offsets in the display list. The pointer type is void because the offsets can 
		/// be bytes, shorts, ints, or floats, depending on the value of <paramref name="type"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="n"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not one of Gl.BYTE, Gl.UNSIGNED_BYTE, Gl.SHORT, 
		/// Gl.UNSIGNED_SHORT, Gl.INT, Gl.UNSIGNED_INT, Gl.FLOAT, Gl.2_BYTES, Gl.3_BYTES, Gl.4_BYTES.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.GenLists"/>
		/// <seealso cref="Gl.ListBase"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PushAttrib"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CallLists(Int32 n, ListNameType type, Object lists)
		{
			GCHandle pin_lists = GCHandle.Alloc(lists, GCHandleType.Pinned);
			try {
				CallLists(n, type, pin_lists.AddrOfPinnedObject());
			} finally {
				pin_lists.Free();
			}
		}

		/// <summary>
		/// delete a contiguous group of display lists
		/// </summary>
		/// <param name="list">
		/// Specifies the integer name of the first display list to delete.
		/// </param>
		/// <param name="range">
		/// Specifies the number of display lists to delete.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="range"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.DeleteLists is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.GenLists"/>
		/// <seealso cref="Gl.IsList"/>
		/// <seealso cref="Gl.NewList"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void DeleteLists(UInt32 list, Int32 range)
		{
			Debug.Assert(Delegates.pglDeleteLists != null, "pglDeleteLists not implemented");
			Delegates.pglDeleteLists(list, range);
			LogCommand("glDeleteLists", null, list, range			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate a contiguous set of empty display lists
		/// </summary>
		/// <param name="range">
		/// Specifies the number of contiguous empty display lists to be generated.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="range"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GenLists is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.NewList"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static UInt32 GenLists(Int32 range)
		{
			UInt32 retValue;

			Debug.Assert(Delegates.pglGenLists != null, "pglGenLists not implemented");
			retValue = Delegates.pglGenLists(range);
			LogCommand("glGenLists", retValue, range			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// set the display-list base for glCallLists
		/// </summary>
		/// <param name="base">
		/// Specifies an integer offset that will be added to Gl\.CallLists offsets to generate display-list names. The initial 
		/// value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ListBase is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CallLists"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ListBase(UInt32 @base)
		{
			Debug.Assert(Delegates.pglListBase != null, "pglListBase not implemented");
			Delegates.pglListBase(@base);
			LogCommand("glListBase", null, @base			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delimit the vertices of a primitive or a group of like primitives
		/// </summary>
		/// <param name="mode">
		/// Specifies the primitive or primitives that will be created from vertices presented between Gl.Begin and the subsequent 
		/// Gl\.End. Ten symbolic constants are accepted: Gl.POINTS, Gl.LINES, Gl.LINE_STRIP, Gl.LINE_LOOP, Gl.TRIANGLES, 
		/// Gl.TRIANGLE_STRIP, Gl.TRIANGLE_FAN, Gl.QUADS, Gl.QUAD_STRIP, and Gl.POLYGON.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is set to an unaccepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Begin is executed between a Gl.Begin and the corresponding execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl\.End is executed without being preceded by a Gl.Begin.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a command other than Gl\.Vertex, Gl\.Color, Gl\.SecondaryColor, Gl\.Index, 
		/// Gl\.Normal, Gl\.FogCoord, Gl\.TexCoord, Gl\.MultiTexCoord, Gl\.VertexAttrib, Gl\.EvalCoord, Gl\.EvalPoint, 
		/// Gl\.ArrayElement, Gl\.Material, Gl\.EdgeFlag, Gl\.CallList, or Gl\.CallLists is executed between the execution of 
		/// Gl.Begin and the corresponding execution Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Execution of Gl\.EnableClientState, Gl\.DisableClientState, Gl\.EdgeFlagPointer, Gl\.FogCoordPointer, 
		/// Gl\.TexCoordPointer, Gl\.ColorPointer, Gl\.SecondaryColorPointer, Gl\.IndexPointer, Gl\.NormalPointer, 
		/// Gl\.VertexPointer, Gl\.VertexAttribPointer, Gl\.InterleavedArrays, or Gl\.PixelStore is not allowed after a call to 
		/// Gl.Begin and before the corresponding call to Gl\.End, but an error may or may not be generated.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Begin(PrimitiveType mode)
		{
			Debug.Assert(Delegates.pglBegin != null, "pglBegin not implemented");
			Delegates.pglBegin((Int32)mode);
			LogCommand("glBegin", null, mode			);
		}

		/// <summary>
		/// draw a bitmap
		/// </summary>
		/// <param name="width">
		/// Specify the pixel width and height of the bitmap image.
		/// </param>
		/// <param name="height">
		/// Specify the pixel width and height of the bitmap image.
		/// </param>
		/// <param name="xorig">
		/// Specify the location of the origin in the bitmap image. The origin is measured from the lower left corner of the bitmap, 
		/// with right and up being the positive axes.
		/// </param>
		/// <param name="yorig">
		/// Specify the location of the origin in the bitmap image. The origin is measured from the lower left corner of the bitmap, 
		/// with right and up being the positive axes.
		/// </param>
		/// <param name="xmove">
		/// Specify the x and y offsets to be added to the current raster position after the bitmap is drawn.
		/// </param>
		/// <param name="ymove">
		/// Specify the x and y offsets to be added to the current raster position after the bitmap is drawn.
		/// </param>
		/// <param name="bitmap">
		/// Specifies the address of the bitmap image.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Bitmap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.BindBuffer"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Bitmap(Int32 width, Int32 height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap)
		{
			unsafe {
				fixed (byte* p_bitmap = bitmap)
				{
					Debug.Assert(Delegates.pglBitmap != null, "pglBitmap not implemented");
					Delegates.pglBitmap(width, height, xorig, yorig, xmove, ymove, p_bitmap);
					LogCommand("glBitmap", null, width, height, xorig, yorig, xmove, ymove, bitmap					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(sbyte red, sbyte green, sbyte blue)
		{
			Debug.Assert(Delegates.pglColor3b != null, "pglColor3b not implemented");
			Delegates.pglColor3b(red, green, blue);
			LogCommand("glColor3b", null, red, green, blue			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3bv != null, "pglColor3bv not implemented");
					Delegates.pglColor3bv(p_v);
					LogCommand("glColor3bv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(double red, double green, double blue)
		{
			Debug.Assert(Delegates.pglColor3d != null, "pglColor3d not implemented");
			Delegates.pglColor3d(red, green, blue);
			LogCommand("glColor3d", null, red, green, blue			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3dv != null, "pglColor3dv not implemented");
					Delegates.pglColor3dv(p_v);
					LogCommand("glColor3dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(float red, float green, float blue)
		{
			Debug.Assert(Delegates.pglColor3f != null, "pglColor3f not implemented");
			Delegates.pglColor3f(red, green, blue);
			LogCommand("glColor3f", null, red, green, blue			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3fv != null, "pglColor3fv not implemented");
					Delegates.pglColor3fv(p_v);
					LogCommand("glColor3fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(Int32 red, Int32 green, Int32 blue)
		{
			Debug.Assert(Delegates.pglColor3i != null, "pglColor3i not implemented");
			Delegates.pglColor3i(red, green, blue);
			LogCommand("glColor3i", null, red, green, blue			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3iv != null, "pglColor3iv not implemented");
					Delegates.pglColor3iv(p_v);
					LogCommand("glColor3iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(Int16 red, Int16 green, Int16 blue)
		{
			Debug.Assert(Delegates.pglColor3s != null, "pglColor3s not implemented");
			Delegates.pglColor3s(red, green, blue);
			LogCommand("glColor3s", null, red, green, blue			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3sv != null, "pglColor3sv not implemented");
					Delegates.pglColor3sv(p_v);
					LogCommand("glColor3sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(byte red, byte green, byte blue)
		{
			Debug.Assert(Delegates.pglColor3ub != null, "pglColor3ub not implemented");
			Delegates.pglColor3ub(red, green, blue);
			LogCommand("glColor3ub", null, red, green, blue			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3ubv != null, "pglColor3ubv not implemented");
					Delegates.pglColor3ubv(p_v);
					LogCommand("glColor3ubv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(UInt32 red, UInt32 green, UInt32 blue)
		{
			Debug.Assert(Delegates.pglColor3ui != null, "pglColor3ui not implemented");
			Delegates.pglColor3ui(red, green, blue);
			LogCommand("glColor3ui", null, red, green, blue			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3uiv != null, "pglColor3uiv not implemented");
					Delegates.pglColor3uiv(p_v);
					LogCommand("glColor3uiv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(UInt16 red, UInt16 green, UInt16 blue)
		{
			Debug.Assert(Delegates.pglColor3us != null, "pglColor3us not implemented");
			Delegates.pglColor3us(red, green, blue);
			LogCommand("glColor3us", null, red, green, blue			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color3(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor3usv != null, "pglColor3usv not implemented");
					Delegates.pglColor3usv(p_v);
					LogCommand("glColor3usv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(sbyte red, sbyte green, sbyte blue, sbyte alpha)
		{
			Debug.Assert(Delegates.pglColor4b != null, "pglColor4b not implemented");
			Delegates.pglColor4b(red, green, blue, alpha);
			LogCommand("glColor4b", null, red, green, blue, alpha			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4bv != null, "pglColor4bv not implemented");
					Delegates.pglColor4bv(p_v);
					LogCommand("glColor4bv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(double red, double green, double blue, double alpha)
		{
			Debug.Assert(Delegates.pglColor4d != null, "pglColor4d not implemented");
			Delegates.pglColor4d(red, green, blue, alpha);
			LogCommand("glColor4d", null, red, green, blue, alpha			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4dv != null, "pglColor4dv not implemented");
					Delegates.pglColor4dv(p_v);
					LogCommand("glColor4dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglColor4f != null, "pglColor4f not implemented");
			Delegates.pglColor4f(red, green, blue, alpha);
			LogCommand("glColor4f", null, red, green, blue, alpha			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4fv != null, "pglColor4fv not implemented");
					Delegates.pglColor4fv(p_v);
					LogCommand("glColor4fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(Int32 red, Int32 green, Int32 blue, Int32 alpha)
		{
			Debug.Assert(Delegates.pglColor4i != null, "pglColor4i not implemented");
			Delegates.pglColor4i(red, green, blue, alpha);
			LogCommand("glColor4i", null, red, green, blue, alpha			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4iv != null, "pglColor4iv not implemented");
					Delegates.pglColor4iv(p_v);
					LogCommand("glColor4iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(Int16 red, Int16 green, Int16 blue, Int16 alpha)
		{
			Debug.Assert(Delegates.pglColor4s != null, "pglColor4s not implemented");
			Delegates.pglColor4s(red, green, blue, alpha);
			LogCommand("glColor4s", null, red, green, blue, alpha			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4sv != null, "pglColor4sv not implemented");
					Delegates.pglColor4sv(p_v);
					LogCommand("glColor4sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(byte red, byte green, byte blue, byte alpha)
		{
			Debug.Assert(Delegates.pglColor4ub != null, "pglColor4ub not implemented");
			Delegates.pglColor4ub(red, green, blue, alpha);
			LogCommand("glColor4ub", null, red, green, blue, alpha			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(byte[] v)
		{
			unsafe {
				fixed (byte* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4ubv != null, "pglColor4ubv not implemented");
					Delegates.pglColor4ubv(p_v);
					LogCommand("glColor4ubv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha)
		{
			Debug.Assert(Delegates.pglColor4ui != null, "pglColor4ui not implemented");
			Delegates.pglColor4ui(red, green, blue, alpha);
			LogCommand("glColor4ui", null, red, green, blue, alpha			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(UInt32[] v)
		{
			unsafe {
				fixed (UInt32* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4uiv != null, "pglColor4uiv not implemented");
					Delegates.pglColor4uiv(p_v);
					LogCommand("glColor4uiv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="red">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="green">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="blue">
		/// Specify new red, green, and blue values for the current color.
		/// </param>
		/// <param name="alpha">
		/// Specifies a new alpha value for the current color. Included only in the four-argument Gl.Color4 commands.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha)
		{
			Debug.Assert(Delegates.pglColor4us != null, "pglColor4us not implemented");
			Delegates.pglColor4us(red, green, blue, alpha);
			LogCommand("glColor4us", null, red, green, blue, alpha			);
		}

		/// <summary>
		/// set the current color
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Color4(UInt16[] v)
		{
			unsafe {
				fixed (UInt16* p_v = v)
				{
					Debug.Assert(Delegates.pglColor4usv != null, "pglColor4usv not implemented");
					Delegates.pglColor4usv(p_v);
					LogCommand("glColor4usv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// flag edges as either boundary or nonboundary
		/// </summary>
		/// <param name="flag">
		/// Specifies the current edge flag value, either Gl.TRUE or Gl.FALSE. The initial value is Gl.TRUE.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.PolygonMode"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EdgeFlag(bool flag)
		{
			Debug.Assert(Delegates.pglEdgeFlag != null, "pglEdgeFlag not implemented");
			Delegates.pglEdgeFlag(flag);
			LogCommand("glEdgeFlag", null, flag			);
		}

		/// <summary>
		/// flag edges as either boundary or nonboundary
		/// </summary>
		/// <param name="flag">
		/// Specifies the current edge flag value, either Gl.TRUE or Gl.FALSE. The initial value is Gl.TRUE.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.PolygonMode"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EdgeFlag(bool[] flag)
		{
			unsafe {
				fixed (bool* p_flag = flag)
				{
					Debug.Assert(Delegates.pglEdgeFlagv != null, "pglEdgeFlagv not implemented");
					Delegates.pglEdgeFlagv(p_flag);
					LogCommand("glEdgeFlagv", null, flag					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// delimit the vertices of a primitive or a group of like primitives
		/// </summary>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is set to an unaccepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Begin is executed between a Gl.Begin and the corresponding execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl\.End is executed without being preceded by a Gl.Begin.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a command other than Gl\.Vertex, Gl\.Color, Gl\.SecondaryColor, Gl\.Index, 
		/// Gl\.Normal, Gl\.FogCoord, Gl\.TexCoord, Gl\.MultiTexCoord, Gl\.VertexAttrib, Gl\.EvalCoord, Gl\.EvalPoint, 
		/// Gl\.ArrayElement, Gl\.Material, Gl\.EdgeFlag, Gl\.CallList, or Gl\.CallLists is executed between the execution of 
		/// Gl.Begin and the corresponding execution Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Execution of Gl\.EnableClientState, Gl\.DisableClientState, Gl\.EdgeFlagPointer, Gl\.FogCoordPointer, 
		/// Gl\.TexCoordPointer, Gl\.ColorPointer, Gl\.SecondaryColorPointer, Gl\.IndexPointer, Gl\.NormalPointer, 
		/// Gl\.VertexPointer, Gl\.VertexAttribPointer, Gl\.InterleavedArrays, or Gl\.PixelStore is not allowed after a call to 
		/// Gl.Begin and before the corresponding call to Gl\.End, but an error may or may not be generated.
		/// </exception>
		/// <seealso cref="Gl.ArrayElement"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.SecondaryColor"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.VertexAttrib"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void End()
		{
			Debug.Assert(Delegates.pglEnd != null, "pglEnd not implemented");
			Delegates.pglEnd();
			LogCommand("glEnd", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(double c)
		{
			Debug.Assert(Delegates.pglIndexd != null, "pglIndexd not implemented");
			Delegates.pglIndexd(c);
			LogCommand("glIndexd", null, c			);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(double[] c)
		{
			unsafe {
				fixed (double* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexdv != null, "pglIndexdv not implemented");
					Delegates.pglIndexdv(p_c);
					LogCommand("glIndexdv", null, c					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(float c)
		{
			Debug.Assert(Delegates.pglIndexf != null, "pglIndexf not implemented");
			Delegates.pglIndexf(c);
			LogCommand("glIndexf", null, c			);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(float[] c)
		{
			unsafe {
				fixed (float* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexfv != null, "pglIndexfv not implemented");
					Delegates.pglIndexfv(p_c);
					LogCommand("glIndexfv", null, c					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(Int32 c)
		{
			Debug.Assert(Delegates.pglIndexi != null, "pglIndexi not implemented");
			Delegates.pglIndexi(c);
			LogCommand("glIndexi", null, c			);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(Int32[] c)
		{
			unsafe {
				fixed (Int32* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexiv != null, "pglIndexiv not implemented");
					Delegates.pglIndexiv(p_c);
					LogCommand("glIndexiv", null, c					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(Int16 c)
		{
			Debug.Assert(Delegates.pglIndexs != null, "pglIndexs not implemented");
			Delegates.pglIndexs(c);
			LogCommand("glIndexs", null, c			);
		}

		/// <summary>
		/// set the current color index
		/// </summary>
		/// <param name="c">
		/// Specifies the new value for the current color index.
		/// </param>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.IndexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Index(Int16[] c)
		{
			unsafe {
				fixed (Int16* p_c = c)
				{
					Debug.Assert(Delegates.pglIndexsv != null, "pglIndexsv not implemented");
					Delegates.pglIndexsv(p_c);
					LogCommand("glIndexsv", null, c					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="nx">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="ny">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="nz">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(sbyte nx, sbyte ny, sbyte nz)
		{
			Debug.Assert(Delegates.pglNormal3b != null, "pglNormal3b not implemented");
			Delegates.pglNormal3b(nx, ny, nz);
			LogCommand("glNormal3b", null, nx, ny, nz			);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:sbyte[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(sbyte[] v)
		{
			unsafe {
				fixed (sbyte* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3bv != null, "pglNormal3bv not implemented");
					Delegates.pglNormal3bv(p_v);
					LogCommand("glNormal3bv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="nx">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="ny">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="nz">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(double nx, double ny, double nz)
		{
			Debug.Assert(Delegates.pglNormal3d != null, "pglNormal3d not implemented");
			Delegates.pglNormal3d(nx, ny, nz);
			LogCommand("glNormal3d", null, nx, ny, nz			);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3dv != null, "pglNormal3dv not implemented");
					Delegates.pglNormal3dv(p_v);
					LogCommand("glNormal3dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="nx">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="ny">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="nz">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(float nx, float ny, float nz)
		{
			Debug.Assert(Delegates.pglNormal3f != null, "pglNormal3f not implemented");
			Delegates.pglNormal3f(nx, ny, nz);
			LogCommand("glNormal3f", null, nx, ny, nz			);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3fv != null, "pglNormal3fv not implemented");
					Delegates.pglNormal3fv(p_v);
					LogCommand("glNormal3fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="nx">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="ny">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="nz">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(Int32 nx, Int32 ny, Int32 nz)
		{
			Debug.Assert(Delegates.pglNormal3i != null, "pglNormal3i not implemented");
			Delegates.pglNormal3i(nx, ny, nz);
			LogCommand("glNormal3i", null, nx, ny, nz			);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3iv != null, "pglNormal3iv not implemented");
					Delegates.pglNormal3iv(p_v);
					LogCommand("glNormal3iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="nx">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="ny">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <param name="nz">
		/// Specify the x, y, and z coordinates of the new current normal. The initial value of the current normal is the unit 
		/// vector, (0, 0, 1).
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(Int16 nx, Int16 ny, Int16 nz)
		{
			Debug.Assert(Delegates.pglNormal3s != null, "pglNormal3s not implemented");
			Delegates.pglNormal3s(nx, ny, nz);
			LogCommand("glNormal3s", null, nx, ny, nz			);
		}

		/// <summary>
		/// set the current normal vector
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.NormalPointer"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Normal3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglNormal3sv != null, "pglNormal3sv not implemented");
					Delegates.pglNormal3sv(p_v);
					LogCommand("glNormal3sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(double x, double y)
		{
			Debug.Assert(Delegates.pglRasterPos2d != null, "pglRasterPos2d not implemented");
			Delegates.pglRasterPos2d(x, y);
			LogCommand("glRasterPos2d", null, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2dv != null, "pglRasterPos2dv not implemented");
					Delegates.pglRasterPos2dv(p_v);
					LogCommand("glRasterPos2dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(float x, float y)
		{
			Debug.Assert(Delegates.pglRasterPos2f != null, "pglRasterPos2f not implemented");
			Delegates.pglRasterPos2f(x, y);
			LogCommand("glRasterPos2f", null, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2fv != null, "pglRasterPos2fv not implemented");
					Delegates.pglRasterPos2fv(p_v);
					LogCommand("glRasterPos2fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglRasterPos2i != null, "pglRasterPos2i not implemented");
			Delegates.pglRasterPos2i(x, y);
			LogCommand("glRasterPos2i", null, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2iv != null, "pglRasterPos2iv not implemented");
					Delegates.pglRasterPos2iv(p_v);
					LogCommand("glRasterPos2iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglRasterPos2s != null, "pglRasterPos2s not implemented");
			Delegates.pglRasterPos2s(x, y);
			LogCommand("glRasterPos2s", null, x, y			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos2sv != null, "pglRasterPos2sv not implemented");
					Delegates.pglRasterPos2sv(p_v);
					LogCommand("glRasterPos2sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglRasterPos3d != null, "pglRasterPos3d not implemented");
			Delegates.pglRasterPos3d(x, y, z);
			LogCommand("glRasterPos3d", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3dv != null, "pglRasterPos3dv not implemented");
					Delegates.pglRasterPos3dv(p_v);
					LogCommand("glRasterPos3dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglRasterPos3f != null, "pglRasterPos3f not implemented");
			Delegates.pglRasterPos3f(x, y, z);
			LogCommand("glRasterPos3f", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3fv != null, "pglRasterPos3fv not implemented");
					Delegates.pglRasterPos3fv(p_v);
					LogCommand("glRasterPos3fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglRasterPos3i != null, "pglRasterPos3i not implemented");
			Delegates.pglRasterPos3i(x, y, z);
			LogCommand("glRasterPos3i", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3iv != null, "pglRasterPos3iv not implemented");
					Delegates.pglRasterPos3iv(p_v);
					LogCommand("glRasterPos3iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglRasterPos3s != null, "pglRasterPos3s not implemented");
			Delegates.pglRasterPos3s(x, y, z);
			LogCommand("glRasterPos3s", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos3sv != null, "pglRasterPos3sv not implemented");
					Delegates.pglRasterPos3sv(p_v);
					LogCommand("glRasterPos3sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="w">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglRasterPos4d != null, "pglRasterPos4d not implemented");
			Delegates.pglRasterPos4d(x, y, z, w);
			LogCommand("glRasterPos4d", null, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4dv != null, "pglRasterPos4dv not implemented");
					Delegates.pglRasterPos4dv(p_v);
					LogCommand("glRasterPos4dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="w">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglRasterPos4f != null, "pglRasterPos4f not implemented");
			Delegates.pglRasterPos4f(x, y, z, w);
			LogCommand("glRasterPos4f", null, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4fv != null, "pglRasterPos4fv not implemented");
					Delegates.pglRasterPos4fv(p_v);
					LogCommand("glRasterPos4fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="w">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglRasterPos4i != null, "pglRasterPos4i not implemented");
			Delegates.pglRasterPos4i(x, y, z, w);
			LogCommand("glRasterPos4i", null, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4iv != null, "pglRasterPos4iv not implemented");
					Delegates.pglRasterPos4iv(p_v);
					LogCommand("glRasterPos4iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <param name="w">
		/// Specify the x, y, z, and w object coordinates (if present) for the raster position.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglRasterPos4s != null, "pglRasterPos4s not implemented");
			Delegates.pglRasterPos4s(x, y, z, w);
			LogCommand("glRasterPos4s", null, x, y, z, w			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the raster position for pixel operations
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RasterPos is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Bitmap"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.TexGen"/>
		/// <seealso cref="Gl.Vertex"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void RasterPos4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglRasterPos4sv != null, "pglRasterPos4sv not implemented");
					Delegates.pglRasterPos4sv(p_v);
					LogCommand("glRasterPos4sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="x1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="y1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="x2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <param name="y2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(double x1, double y1, double x2, double y2)
		{
			Debug.Assert(Delegates.pglRectd != null, "pglRectd not implemented");
			Delegates.pglRectd(x1, y1, x2, y2);
			LogCommand("glRectd", null, x1, y1, x2, y2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(double[] v1, double[] v2)
		{
			unsafe {
				fixed (double* p_v1 = v1)
				fixed (double* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectdv != null, "pglRectdv not implemented");
					Delegates.pglRectdv(p_v1, p_v2);
					LogCommand("glRectdv", null, v1, v2					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="x1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="y1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="x2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <param name="y2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(float x1, float y1, float x2, float y2)
		{
			Debug.Assert(Delegates.pglRectf != null, "pglRectf not implemented");
			Delegates.pglRectf(x1, y1, x2, y2);
			LogCommand("glRectf", null, x1, y1, x2, y2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(float[] v1, float[] v2)
		{
			unsafe {
				fixed (float* p_v1 = v1)
				fixed (float* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectfv != null, "pglRectfv not implemented");
					Delegates.pglRectfv(p_v1, p_v2);
					LogCommand("glRectfv", null, v1, v2					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="x1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="y1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="x2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <param name="y2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(Int32 x1, Int32 y1, Int32 x2, Int32 y2)
		{
			Debug.Assert(Delegates.pglRecti != null, "pglRecti not implemented");
			Delegates.pglRecti(x1, y1, x2, y2);
			LogCommand("glRecti", null, x1, y1, x2, y2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(Int32[] v1, Int32[] v2)
		{
			unsafe {
				fixed (Int32* p_v1 = v1)
				fixed (Int32* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectiv != null, "pglRectiv not implemented");
					Delegates.pglRectiv(p_v1, p_v2);
					LogCommand("glRectiv", null, v1, v2					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="x1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="y1">
		/// Specify one vertex of a rectangle.
		/// </param>
		/// <param name="x2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <param name="y2">
		/// Specify the opposite vertex of the rectangle.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(Int16 x1, Int16 y1, Int16 x2, Int16 y2)
		{
			Debug.Assert(Delegates.pglRects != null, "pglRects not implemented");
			Delegates.pglRects(x1, y1, x2, y2);
			LogCommand("glRects", null, x1, y1, x2, y2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// draw a rectangle
		/// </summary>
		/// <param name="v1">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <param name="v2">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rect is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rect(Int16[] v1, Int16[] v2)
		{
			unsafe {
				fixed (Int16* p_v1 = v1)
				fixed (Int16* p_v2 = v2)
				{
					Debug.Assert(Delegates.pglRectsv != null, "pglRectsv not implemented");
					Delegates.pglRectsv(p_v1, p_v2);
					LogCommand("glRectsv", null, v1, v2					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(double s)
		{
			Debug.Assert(Delegates.pglTexCoord1d != null, "pglTexCoord1d not implemented");
			Delegates.pglTexCoord1d(s);
			LogCommand("glTexCoord1d", null, s			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1dv != null, "pglTexCoord1dv not implemented");
					Delegates.pglTexCoord1dv(p_v);
					LogCommand("glTexCoord1dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(float s)
		{
			Debug.Assert(Delegates.pglTexCoord1f != null, "pglTexCoord1f not implemented");
			Delegates.pglTexCoord1f(s);
			LogCommand("glTexCoord1f", null, s			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1fv != null, "pglTexCoord1fv not implemented");
					Delegates.pglTexCoord1fv(p_v);
					LogCommand("glTexCoord1fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(Int32 s)
		{
			Debug.Assert(Delegates.pglTexCoord1i != null, "pglTexCoord1i not implemented");
			Delegates.pglTexCoord1i(s);
			LogCommand("glTexCoord1i", null, s			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1iv != null, "pglTexCoord1iv not implemented");
					Delegates.pglTexCoord1iv(p_v);
					LogCommand("glTexCoord1iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(Int16 s)
		{
			Debug.Assert(Delegates.pglTexCoord1s != null, "pglTexCoord1s not implemented");
			Delegates.pglTexCoord1s(s);
			LogCommand("glTexCoord1s", null, s			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord1(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord1sv != null, "pglTexCoord1sv not implemented");
					Delegates.pglTexCoord1sv(p_v);
					LogCommand("glTexCoord1sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(double s, double t)
		{
			Debug.Assert(Delegates.pglTexCoord2d != null, "pglTexCoord2d not implemented");
			Delegates.pglTexCoord2d(s, t);
			LogCommand("glTexCoord2d", null, s, t			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2dv != null, "pglTexCoord2dv not implemented");
					Delegates.pglTexCoord2dv(p_v);
					LogCommand("glTexCoord2dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(float s, float t)
		{
			Debug.Assert(Delegates.pglTexCoord2f != null, "pglTexCoord2f not implemented");
			Delegates.pglTexCoord2f(s, t);
			LogCommand("glTexCoord2f", null, s, t			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2fv != null, "pglTexCoord2fv not implemented");
					Delegates.pglTexCoord2fv(p_v);
					LogCommand("glTexCoord2fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(Int32 s, Int32 t)
		{
			Debug.Assert(Delegates.pglTexCoord2i != null, "pglTexCoord2i not implemented");
			Delegates.pglTexCoord2i(s, t);
			LogCommand("glTexCoord2i", null, s, t			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2iv != null, "pglTexCoord2iv not implemented");
					Delegates.pglTexCoord2iv(p_v);
					LogCommand("glTexCoord2iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(Int16 s, Int16 t)
		{
			Debug.Assert(Delegates.pglTexCoord2s != null, "pglTexCoord2s not implemented");
			Delegates.pglTexCoord2s(s, t);
			LogCommand("glTexCoord2s", null, s, t			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord2sv != null, "pglTexCoord2sv not implemented");
					Delegates.pglTexCoord2sv(p_v);
					LogCommand("glTexCoord2sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(double s, double t, double r)
		{
			Debug.Assert(Delegates.pglTexCoord3d != null, "pglTexCoord3d not implemented");
			Delegates.pglTexCoord3d(s, t, r);
			LogCommand("glTexCoord3d", null, s, t, r			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3dv != null, "pglTexCoord3dv not implemented");
					Delegates.pglTexCoord3dv(p_v);
					LogCommand("glTexCoord3dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(float s, float t, float r)
		{
			Debug.Assert(Delegates.pglTexCoord3f != null, "pglTexCoord3f not implemented");
			Delegates.pglTexCoord3f(s, t, r);
			LogCommand("glTexCoord3f", null, s, t, r			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3fv != null, "pglTexCoord3fv not implemented");
					Delegates.pglTexCoord3fv(p_v);
					LogCommand("glTexCoord3fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(Int32 s, Int32 t, Int32 r)
		{
			Debug.Assert(Delegates.pglTexCoord3i != null, "pglTexCoord3i not implemented");
			Delegates.pglTexCoord3i(s, t, r);
			LogCommand("glTexCoord3i", null, s, t, r			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3iv != null, "pglTexCoord3iv not implemented");
					Delegates.pglTexCoord3iv(p_v);
					LogCommand("glTexCoord3iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(Int16 s, Int16 t, Int16 r)
		{
			Debug.Assert(Delegates.pglTexCoord3s != null, "pglTexCoord3s not implemented");
			Delegates.pglTexCoord3s(s, t, r);
			LogCommand("glTexCoord3s", null, s, t, r			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord3sv != null, "pglTexCoord3sv not implemented");
					Delegates.pglTexCoord3sv(p_v);
					LogCommand("glTexCoord3sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="q">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(double s, double t, double r, double q)
		{
			Debug.Assert(Delegates.pglTexCoord4d != null, "pglTexCoord4d not implemented");
			Delegates.pglTexCoord4d(s, t, r, q);
			LogCommand("glTexCoord4d", null, s, t, r, q			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4dv != null, "pglTexCoord4dv not implemented");
					Delegates.pglTexCoord4dv(p_v);
					LogCommand("glTexCoord4dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="q">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(float s, float t, float r, float q)
		{
			Debug.Assert(Delegates.pglTexCoord4f != null, "pglTexCoord4f not implemented");
			Delegates.pglTexCoord4f(s, t, r, q);
			LogCommand("glTexCoord4f", null, s, t, r, q			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4fv != null, "pglTexCoord4fv not implemented");
					Delegates.pglTexCoord4fv(p_v);
					LogCommand("glTexCoord4fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="q">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(Int32 s, Int32 t, Int32 r, Int32 q)
		{
			Debug.Assert(Delegates.pglTexCoord4i != null, "pglTexCoord4i not implemented");
			Delegates.pglTexCoord4i(s, t, r, q);
			LogCommand("glTexCoord4i", null, s, t, r, q			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4iv != null, "pglTexCoord4iv not implemented");
					Delegates.pglTexCoord4iv(p_v);
					LogCommand("glTexCoord4iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="s">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="t">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="r">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="q">
		/// Specify s, t, r, and q texture coordinates. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(Int16 s, Int16 t, Int16 r, Int16 q)
		{
			Debug.Assert(Delegates.pglTexCoord4s != null, "pglTexCoord4s not implemented");
			Delegates.pglTexCoord4s(s, t, r, q);
			LogCommand("glTexCoord4s", null, s, t, r, q			);
		}

		/// <summary>
		/// set the current texture coordinates
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexCoord4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglTexCoord4sv != null, "pglTexCoord4sv not implemented");
					Delegates.pglTexCoord4sv(p_v);
					LogCommand("glTexCoord4sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(double x, double y)
		{
			Debug.Assert(Delegates.pglVertex2d != null, "pglVertex2d not implemented");
			Delegates.pglVertex2d(x, y);
			LogCommand("glVertex2d", null, x, y			);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2dv != null, "pglVertex2dv not implemented");
					Delegates.pglVertex2dv(p_v);
					LogCommand("glVertex2dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(float x, float y)
		{
			Debug.Assert(Delegates.pglVertex2f != null, "pglVertex2f not implemented");
			Delegates.pglVertex2f(x, y);
			LogCommand("glVertex2f", null, x, y			);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2fv != null, "pglVertex2fv not implemented");
					Delegates.pglVertex2fv(p_v);
					LogCommand("glVertex2fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(Int32 x, Int32 y)
		{
			Debug.Assert(Delegates.pglVertex2i != null, "pglVertex2i not implemented");
			Delegates.pglVertex2i(x, y);
			LogCommand("glVertex2i", null, x, y			);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2iv != null, "pglVertex2iv not implemented");
					Delegates.pglVertex2iv(p_v);
					LogCommand("glVertex2iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(Int16 x, Int16 y)
		{
			Debug.Assert(Delegates.pglVertex2s != null, "pglVertex2s not implemented");
			Delegates.pglVertex2s(x, y);
			LogCommand("glVertex2s", null, x, y			);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex2(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex2sv != null, "pglVertex2sv not implemented");
					Delegates.pglVertex2sv(p_v);
					LogCommand("glVertex2sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglVertex3d != null, "pglVertex3d not implemented");
			Delegates.pglVertex3d(x, y, z);
			LogCommand("glVertex3d", null, x, y, z			);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3dv != null, "pglVertex3dv not implemented");
					Delegates.pglVertex3dv(p_v);
					LogCommand("glVertex3dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglVertex3f != null, "pglVertex3f not implemented");
			Delegates.pglVertex3f(x, y, z);
			LogCommand("glVertex3f", null, x, y, z			);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3fv != null, "pglVertex3fv not implemented");
					Delegates.pglVertex3fv(p_v);
					LogCommand("glVertex3fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(Int32 x, Int32 y, Int32 z)
		{
			Debug.Assert(Delegates.pglVertex3i != null, "pglVertex3i not implemented");
			Delegates.pglVertex3i(x, y, z);
			LogCommand("glVertex3i", null, x, y, z			);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3iv != null, "pglVertex3iv not implemented");
					Delegates.pglVertex3iv(p_v);
					LogCommand("glVertex3iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(Int16 x, Int16 y, Int16 z)
		{
			Debug.Assert(Delegates.pglVertex3s != null, "pglVertex3s not implemented");
			Delegates.pglVertex3s(x, y, z);
			LogCommand("glVertex3s", null, x, y, z			);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex3(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex3sv != null, "pglVertex3sv not implemented");
					Delegates.pglVertex3sv(p_v);
					LogCommand("glVertex3sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="w">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(double x, double y, double z, double w)
		{
			Debug.Assert(Delegates.pglVertex4d != null, "pglVertex4d not implemented");
			Delegates.pglVertex4d(x, y, z, w);
			LogCommand("glVertex4d", null, x, y, z, w			);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4dv != null, "pglVertex4dv not implemented");
					Delegates.pglVertex4dv(p_v);
					LogCommand("glVertex4dv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="w">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(float x, float y, float z, float w)
		{
			Debug.Assert(Delegates.pglVertex4f != null, "pglVertex4f not implemented");
			Delegates.pglVertex4f(x, y, z, w);
			LogCommand("glVertex4f", null, x, y, z, w			);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4fv != null, "pglVertex4fv not implemented");
					Delegates.pglVertex4fv(p_v);
					LogCommand("glVertex4fv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="w">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(Int32 x, Int32 y, Int32 z, Int32 w)
		{
			Debug.Assert(Delegates.pglVertex4i != null, "pglVertex4i not implemented");
			Delegates.pglVertex4i(x, y, z, w);
			LogCommand("glVertex4i", null, x, y, z, w			);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4iv != null, "pglVertex4iv not implemented");
					Delegates.pglVertex4iv(p_v);
					LogCommand("glVertex4iv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="x">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="y">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="z">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <param name="w">
		/// Specify x, y, z, and w coordinates of a vertex. Not all parameters are present in all forms of the command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(Int16 x, Int16 y, Int16 z, Int16 w)
		{
			Debug.Assert(Delegates.pglVertex4s != null, "pglVertex4s not implemented");
			Delegates.pglVertex4s(x, y, z, w);
			LogCommand("glVertex4s", null, x, y, z, w			);
		}

		/// <summary>
		/// specify a vertex
		/// </summary>
		/// <param name="v">
		/// A <see cref="T:Int16[]"/>.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.EdgeFlag"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.FogCoord"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Material"/>
		/// <seealso cref="Gl.MultiTexCoord"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.Rect"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.VertexPointer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Vertex4(Int16[] v)
		{
			unsafe {
				fixed (Int16* p_v = v)
				{
					Debug.Assert(Delegates.pglVertex4sv != null, "pglVertex4sv not implemented");
					Delegates.pglVertex4sv(p_v);
					LogCommand("glVertex4sv", null, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify a plane against which all geometry is clipped
		/// </summary>
		/// <param name="plane">
		/// Specifies which clipping plane is being positioned. Symbolic names of the form Gl.CLIP_PLANEi, where i is an integer 
		/// between 0 and Gl.MAX_CLIP_PLANES-1, are accepted.
		/// </param>
		/// <param name="equation">
		/// Specifies the address of an array of four double-precision floating-point values. These values are interpreted as a 
		/// plane equation.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="plane"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ClipPlane is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ClipPlane(ClipPlaneName plane, double[] equation)
		{
			unsafe {
				fixed (double* p_equation = equation)
				{
					Debug.Assert(Delegates.pglClipPlane != null, "pglClipPlane not implemented");
					Delegates.pglClipPlane((Int32)plane, p_equation);
					LogCommand("glClipPlane", null, plane, equation					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// cause a material color to track the current color
		/// </summary>
		/// <param name="face">
		/// Specifies whether front, back, or both front and back material parameters should track the current color. Accepted 
		/// values are Gl.FRONT, Gl.BACK, and Gl.FRONT_AND_BACK. The initial value is Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="mode">
		/// Specifies which of several material parameters track the current color. Accepted values are Gl.EMISSION, Gl.AMBIENT, 
		/// Gl.DIFFUSE, Gl.SPECULAR, and Gl.AMBIENT_AND_DIFFUSE. The initial value is Gl.AMBIENT_AND_DIFFUSE.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="face"/> or <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ColorMaterial is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.ColorPointer"/>
		/// <seealso cref="Gl.DrawArrays"/>
		/// <seealso cref="Gl.DrawElements"/>
		/// <seealso cref="Gl.DrawRangeElements"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ColorMaterial(MaterialFace face, ColorMaterialParameter mode)
		{
			Debug.Assert(Delegates.pglColorMaterial != null, "pglColorMaterial not implemented");
			Delegates.pglColorMaterial((Int32)face, (Int32)mode);
			LogCommand("glColorMaterial", null, face, mode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and 
		/// Gl.FOG_COORD_SRC are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
		/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY and <paramref name="params"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Fog is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(FogParameter pname, float param)
		{
			Debug.Assert(Delegates.pglFogf != null, "pglFogf not implemented");
			Delegates.pglFogf((Int32)pname, param);
			LogCommand("glFogf", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and 
		/// Gl.FOG_COORD_SRC are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
		/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY and <paramref name="params"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Fog is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(FogParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglFogfv != null, "pglFogfv not implemented");
					Delegates.pglFogfv((Int32)pname, p_params);
					LogCommand("glFogfv", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and 
		/// Gl.FOG_COORD_SRC are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
		/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY and <paramref name="params"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Fog is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(FogParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglFogi != null, "pglFogi not implemented");
			Delegates.pglFogi((Int32)pname, param);
			LogCommand("glFogi", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify fog parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued fog parameter. Gl.FOG_MODE, Gl.FOG_DENSITY, Gl.FOG_START, Gl.FOG_END, Gl.FOG_INDEX, and 
		/// Gl.FOG_COORD_SRC are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value, or if <paramref name="pname"/> is 
		/// Gl.FOG_MODE and <paramref name="params"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="pname"/> is Gl.FOG_DENSITY and <paramref name="params"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Fog is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Enable"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Fog(FogParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglFogiv != null, "pglFogiv not implemented");
					Delegates.pglFogiv((Int32)pname, p_params);
					LogCommand("glFogiv", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form Gl.LIGHTi, where i ranges from 0 to the value of Gl.MAX_LIGHTS - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, 
		/// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <paramref name="pname"/> of light source <paramref name="light"/> will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a spot exponent value is specified outside the range 0128, or if spot cutoff is 
		/// specified outside the range 090 (except for the special value 180), or if a negative attenuation factor is specified.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Light is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(LightName light, LightParameter pname, float param)
		{
			Debug.Assert(Delegates.pglLightf != null, "pglLightf not implemented");
			Delegates.pglLightf((Int32)light, (Int32)pname, param);
			LogCommand("glLightf", null, light, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form Gl.LIGHTi, where i ranges from 0 to the value of Gl.MAX_LIGHTS - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, 
		/// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a spot exponent value is specified outside the range 0128, or if spot cutoff is 
		/// specified outside the range 090 (except for the special value 180), or if a negative attenuation factor is specified.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Light is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(LightName light, LightParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightfv != null, "pglLightfv not implemented");
					Delegates.pglLightfv((Int32)light, (Int32)pname, p_params);
					LogCommand("glLightfv", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form Gl.LIGHTi, where i ranges from 0 to the value of Gl.MAX_LIGHTS - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, 
		/// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter <paramref name="pname"/> of light source <paramref name="light"/> will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a spot exponent value is specified outside the range 0128, or if spot cutoff is 
		/// specified outside the range 090 (except for the special value 180), or if a negative attenuation factor is specified.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Light is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(LightName light, LightParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLighti != null, "pglLighti not implemented");
			Delegates.pglLighti((Int32)light, (Int32)pname, param);
			LogCommand("glLighti", null, light, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set light source parameters
		/// </summary>
		/// <param name="light">
		/// Specifies a light. The number of lights depends on the implementation, but at least eight lights are supported. They are 
		/// identified by symbolic names of the form Gl.LIGHTi, where i ranges from 0 to the value of Gl.MAX_LIGHTS - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a single-valued light source parameter for <paramref name="light"/>. Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, 
		/// Gl.CONSTANT_ATTENUATION, Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a spot exponent value is specified outside the range 0128, or if spot cutoff is 
		/// specified outside the range 090 (except for the special value 180), or if a negative attenuation factor is specified.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Light is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.LightModel"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Light(LightName light, LightParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightiv != null, "pglLightiv not implemented");
					Delegates.pglLightiv((Int32)light, (Int32)pname, p_params);
					LogCommand("glLightiv", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. Gl.LIGHT_MODEL_LOCAL_VIEWER, Gl.LIGHT_MODEL_COLOR_CONTROL, and 
		/// Gl.LIGHT_MODEL_TWO_SIDE are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="param"/> will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is Gl.LIGHT_MODEL_COLOR_CONTROL and <paramref name="params"/> 
		/// is not one of Gl.SINGLE_COLOR or Gl.SEPARATE_SPECULAR_COLOR.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LightModel is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(LightModelParameter pname, float param)
		{
			Debug.Assert(Delegates.pglLightModelf != null, "pglLightModelf not implemented");
			Delegates.pglLightModelf((Int32)pname, param);
			LogCommand("glLightModelf", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. Gl.LIGHT_MODEL_LOCAL_VIEWER, Gl.LIGHT_MODEL_COLOR_CONTROL, and 
		/// Gl.LIGHT_MODEL_TWO_SIDE are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is Gl.LIGHT_MODEL_COLOR_CONTROL and <paramref name="params"/> 
		/// is not one of Gl.SINGLE_COLOR or Gl.SEPARATE_SPECULAR_COLOR.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LightModel is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(LightModelParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightModelfv != null, "pglLightModelfv not implemented");
					Delegates.pglLightModelfv((Int32)pname, p_params);
					LogCommand("glLightModelfv", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. Gl.LIGHT_MODEL_LOCAL_VIEWER, Gl.LIGHT_MODEL_COLOR_CONTROL, and 
		/// Gl.LIGHT_MODEL_TWO_SIDE are accepted.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="param"/> will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is Gl.LIGHT_MODEL_COLOR_CONTROL and <paramref name="params"/> 
		/// is not one of Gl.SINGLE_COLOR or Gl.SEPARATE_SPECULAR_COLOR.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LightModel is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(LightModelParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglLightModeli != null, "pglLightModeli not implemented");
			Delegates.pglLightModeli((Int32)pname, param);
			LogCommand("glLightModeli", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the lighting model parameters
		/// </summary>
		/// <param name="pname">
		/// Specifies a single-valued lighting model parameter. Gl.LIGHT_MODEL_LOCAL_VIEWER, Gl.LIGHT_MODEL_COLOR_CONTROL, and 
		/// Gl.LIGHT_MODEL_TWO_SIDE are accepted.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is Gl.LIGHT_MODEL_COLOR_CONTROL and <paramref name="params"/> 
		/// is not one of Gl.SINGLE_COLOR or Gl.SEPARATE_SPECULAR_COLOR.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LightModel is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LightModel(LightModelParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglLightModeliv != null, "pglLightModeliv not implemented");
					Delegates.pglLightModeliv((Int32)pname, p_params);
					LogCommand("glLightModeliv", null, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the line stipple pattern
		/// </summary>
		/// <param name="factor">
		/// Specifies a multiplier for each bit in the line stipple pattern. If <paramref name="factor"/> is 3, for example, each 
		/// bit in the pattern is used three times before the next bit in the pattern is used. <paramref name="factor"/> is clamped 
		/// to the range [1, 256] and defaults to 1.
		/// </param>
		/// <param name="pattern">
		/// Specifies a 16-bit integer whose bit pattern determines which fragments of a line will be drawn when the line is 
		/// rasterized. Bit zero is used first; the default pattern is all 1's.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LineStipple is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LineWidth"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LineStipple(Int32 factor, UInt16 pattern)
		{
			Debug.Assert(Delegates.pglLineStipple != null, "pglLineStipple not implemented");
			Delegates.pglLineStipple(factor, pattern);
			LogCommand("glLineStipple", null, factor, pattern			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter Gl.SHININESS will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a specular exponent outside the range 0128 is specified.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(MaterialFace face, MaterialParameter pname, float param)
		{
			Debug.Assert(Delegates.pglMaterialf != null, "pglMaterialf not implemented");
			Delegates.pglMaterialf((Int32)face, (Int32)pname, param);
			LogCommand("glMaterialf", null, face, pname, param			);
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a specular exponent outside the range 0128 is specified.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(MaterialFace face, MaterialParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglMaterialfv != null, "pglMaterialfv not implemented");
					Delegates.pglMaterialfv((Int32)face, (Int32)pname, p_params);
					LogCommand("glMaterialfv", null, face, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
		/// </param>
		/// <param name="param">
		/// Specifies the value that parameter Gl.SHININESS will be set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a specular exponent outside the range 0128 is specified.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(MaterialFace face, MaterialParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglMateriali != null, "pglMateriali not implemented");
			Delegates.pglMateriali((Int32)face, (Int32)pname, param);
			LogCommand("glMateriali", null, face, pname, param			);
		}

		/// <summary>
		/// specify material parameters for the lighting model
		/// </summary>
		/// <param name="face">
		/// Specifies which face or faces are being updated. Must be one of Gl.FRONT, Gl.BACK, or Gl.FRONT_AND_BACK.
		/// </param>
		/// <param name="pname">
		/// Specifies the single-valued material parameter of the face or faces that is being updated. Must be Gl.SHININESS.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if a specular exponent outside the range 0128 is specified.
		/// </exception>
		/// <seealso cref="Gl.ColorMaterial"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Material(MaterialFace face, MaterialParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglMaterialiv != null, "pglMaterialiv not implemented");
					Delegates.pglMaterialiv((Int32)face, (Int32)pname, p_params);
					LogCommand("glMaterialiv", null, face, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set the polygon stippling pattern
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PolygonStipple is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.LineStipple"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PolygonStipple(byte[] mask)
		{
			unsafe {
				fixed (byte* p_mask = mask)
				{
					Debug.Assert(Delegates.pglPolygonStipple != null, "pglPolygonStipple not implemented");
					Delegates.pglPolygonStipple(p_mask);
					LogCommand("glPolygonStipple", null, mask					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// select flat or smooth shading
		/// </summary>
		/// <param name="mode">
		/// Specifies a symbolic value representing a shading technique. Accepted values are Gl.FLAT and Gl.SMOOTH. The initial 
		/// value is Gl.SMOOTH.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is any value other than Gl.FLAT or Gl.SMOOTH.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ShadeModel is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Light"/>
		/// <seealso cref="Gl.LightModel"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ShadeModel(ShadingModel mode)
		{
			Debug.Assert(Delegates.pglShadeModel != null, "pglShadeModel not implemented");
			Delegates.pglShadeModel((Int32)mode);
			LogCommand("glShadeModel", null, mode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL or Gl.POINT_SPRITE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA, 
		/// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA, 
		/// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of Gl.ADD, Gl.ADD_SIGNED, Gl.INTERPOLATE, Gl.MODULATE, Gl.DECAL, Gl.BLEND, 
		/// Gl.REPLACE, Gl.SUBTRACT, Gl.COMBINE, Gl.TEXTURE, Gl.CONSTANT, Gl.PRIMARY_COLOR, Gl.PREVIOUS, Gl.SRC_COLOR, 
		/// Gl.ONE_MINUS_SRC_COLOR, Gl.SRC_ALPHA, Gl.ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture 
		/// coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when 
		/// specifying the Gl.RGB_SCALE or Gl.ALPHA_SCALE.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted 
		/// defined values, or when <paramref name="params"/> should have a defined constant value (based on the value of <paramref 
		/// name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the <paramref name="params"/> value for Gl.RGB_SCALE or Gl.ALPHA_SCALE are not one of 
		/// 1.0, 2.0, or 4.0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexEnv is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float param)
		{
			Debug.Assert(Delegates.pglTexEnvf != null, "pglTexEnvf not implemented");
			Delegates.pglTexEnvf((Int32)target, (Int32)pname, param);
			LogCommand("glTexEnvf", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL or Gl.POINT_SPRITE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA, 
		/// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA, 
		/// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted 
		/// defined values, or when <paramref name="params"/> should have a defined constant value (based on the value of <paramref 
		/// name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the <paramref name="params"/> value for Gl.RGB_SCALE or Gl.ALPHA_SCALE are not one of 
		/// 1.0, 2.0, or 4.0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexEnv is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnvfv != null, "pglTexEnvfv not implemented");
					Delegates.pglTexEnvfv((Int32)target, (Int32)pname, p_params);
					LogCommand("glTexEnvfv", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL or Gl.POINT_SPRITE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA, 
		/// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA, 
		/// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
		/// </param>
		/// <param name="param">
		/// Specifies a single symbolic constant, one of Gl.ADD, Gl.ADD_SIGNED, Gl.INTERPOLATE, Gl.MODULATE, Gl.DECAL, Gl.BLEND, 
		/// Gl.REPLACE, Gl.SUBTRACT, Gl.COMBINE, Gl.TEXTURE, Gl.CONSTANT, Gl.PRIMARY_COLOR, Gl.PREVIOUS, Gl.SRC_COLOR, 
		/// Gl.ONE_MINUS_SRC_COLOR, Gl.SRC_ALPHA, Gl.ONE_MINUS_SRC_ALPHA, a single boolean value for the point sprite texture 
		/// coordinate replacement, a single floating-point value for the texture level-of-detail bias, or 1.0, 2.0, or 4.0 when 
		/// specifying the Gl.RGB_SCALE or Gl.ALPHA_SCALE.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted 
		/// defined values, or when <paramref name="params"/> should have a defined constant value (based on the value of <paramref 
		/// name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the <paramref name="params"/> value for Gl.RGB_SCALE or Gl.ALPHA_SCALE are not one of 
		/// 1.0, 2.0, or 4.0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexEnv is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexEnvi != null, "pglTexEnvi not implemented");
			Delegates.pglTexEnvi((Int32)target, (Int32)pname, param);
			LogCommand("glTexEnvi", null, target, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL or Gl.POINT_SPRITE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a single-valued texture environment parameter. May be either Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, Gl.SRC0_ALPHA, 
		/// Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, Gl.OPERAND1_ALPHA, 
		/// Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="target"/> or <paramref name="pname"/> is not one of the accepted 
		/// defined values, or when <paramref name="params"/> should have a defined constant value (based on the value of <paramref 
		/// name="pname"/>) and does not.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if the <paramref name="params"/> value for Gl.RGB_SCALE or Gl.ALPHA_SCALE are not one of 
		/// 1.0, 2.0, or 4.0.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexEnv is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexEnv(TextureEnvTarget target, TextureEnvParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexEnviv != null, "pglTexEnviv not implemented");
					Delegates.pglTexEnviv((Int32)target, (Int32)pname, p_params);
					LogCommand("glTexEnviv", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of Gl.OBJECT_LINEAR, Gl.EYE_LINEAR, Gl.SPHERE_MAP, 
		/// Gl.NORMAL_MAP, or Gl.REFLECTION_MAP.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted defined value, 
		/// or when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE and <paramref name="params"/> is not an accepted defined value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE, <paramref name="params"/> is 
		/// Gl.SPHERE_MAP, and <paramref name="coord"/> is either Gl.R or Gl.Q.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, double param)
		{
			Debug.Assert(Delegates.pglTexGend != null, "pglTexGend not implemented");
			Delegates.pglTexGend((Int32)coord, (Int32)pname, param);
			LogCommand("glTexGend", null, coord, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:double[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted defined value, 
		/// or when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE and <paramref name="params"/> is not an accepted defined value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE, <paramref name="params"/> is 
		/// Gl.SPHERE_MAP, and <paramref name="coord"/> is either Gl.R or Gl.Q.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGendv != null, "pglTexGendv not implemented");
					Delegates.pglTexGendv((Int32)coord, (Int32)pname, p_params);
					LogCommand("glTexGendv", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of Gl.OBJECT_LINEAR, Gl.EYE_LINEAR, Gl.SPHERE_MAP, 
		/// Gl.NORMAL_MAP, or Gl.REFLECTION_MAP.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted defined value, 
		/// or when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE and <paramref name="params"/> is not an accepted defined value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE, <paramref name="params"/> is 
		/// Gl.SPHERE_MAP, and <paramref name="coord"/> is either Gl.R or Gl.Q.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, float param)
		{
			Debug.Assert(Delegates.pglTexGenf != null, "pglTexGenf not implemented");
			Delegates.pglTexGenf((Int32)coord, (Int32)pname, param);
			LogCommand("glTexGenf", null, coord, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted defined value, 
		/// or when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE and <paramref name="params"/> is not an accepted defined value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE, <paramref name="params"/> is 
		/// Gl.SPHERE_MAP, and <paramref name="coord"/> is either Gl.R or Gl.Q.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGenfv != null, "pglTexGenfv not implemented");
					Delegates.pglTexGenfv((Int32)coord, (Int32)pname, p_params);
					LogCommand("glTexGenfv", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
		/// </param>
		/// <param name="param">
		/// Specifies a single-valued texture generation parameter, one of Gl.OBJECT_LINEAR, Gl.EYE_LINEAR, Gl.SPHERE_MAP, 
		/// Gl.NORMAL_MAP, or Gl.REFLECTION_MAP.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted defined value, 
		/// or when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE and <paramref name="params"/> is not an accepted defined value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE, <paramref name="params"/> is 
		/// Gl.SPHERE_MAP, and <paramref name="coord"/> is either Gl.R or Gl.Q.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglTexGeni != null, "pglTexGeni not implemented");
			Delegates.pglTexGeni((Int32)coord, (Int32)pname, param);
			LogCommand("glTexGeni", null, coord, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the generation of texture coordinates
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be one of Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the texture-coordinate generation function. Must be Gl.TEXTURE_GEN_MODE.
		/// </param>
		/// <param name="params">
		/// A <see cref="T:Int32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="coord"/> or <paramref name="pname"/> is not an accepted defined value, 
		/// or when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE and <paramref name="params"/> is not an accepted defined value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated when <paramref name="pname"/> is Gl.TEXTURE_GEN_MODE, <paramref name="params"/> is 
		/// Gl.SPHERE_MAP, and <paramref name="coord"/> is either Gl.R or Gl.Q.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.TexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.TexEnv"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexParameter"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void TexGen(TextureCoordName coord, TextureGenParameter pname, Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglTexGeniv != null, "pglTexGeniv not implemented");
					Delegates.pglTexGeniv((Int32)coord, (Int32)pname, p_params);
					LogCommand("glTexGeniv", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// controls feedback mode
		/// </summary>
		/// <param name="size">
		/// Specifies the maximum number of values that can be written into <paramref name="buffer"/>.
		/// </param>
		/// <param name="type">
		/// Specifies a symbolic constant that describes the information that will be returned for each vertex. Gl.2D, Gl.3D, 
		/// Gl.3D_COLOR, Gl.3D_COLOR_TEXTURE, and Gl.4D_COLOR_TEXTURE are accepted.
		/// </param>
		/// <param name="buffer">
		/// Returns the feedback data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.FeedbackBuffer is called while the render mode is Gl.FEEDBACK, or if 
		/// Gl\.RenderMode is called with argument Gl.FEEDBACK before Gl.FeedbackBuffer is called at least once.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.FeedbackBuffer is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.LineStipple"/>
		/// <seealso cref="Gl.PassThrough"/>
		/// <seealso cref="Gl.PolygonMode"/>
		/// <seealso cref="Gl.RenderMode"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FeedbackBuffer(Int32 size, FeedbackType type, params float[] buffer)
		{
			unsafe {
				fixed (float* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglFeedbackBuffer != null, "pglFeedbackBuffer not implemented");
					Delegates.pglFeedbackBuffer(size, (Int32)type, p_buffer);
					LogCommand("glFeedbackBuffer", null, size, type, buffer					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// controls feedback mode
		/// </summary>
		/// <param name="type">
		/// Specifies a symbolic constant that describes the information that will be returned for each vertex. Gl.2D, Gl.3D, 
		/// Gl.3D_COLOR, Gl.3D_COLOR_TEXTURE, and Gl.4D_COLOR_TEXTURE are accepted.
		/// </param>
		/// <param name="buffer">
		/// Returns the feedback data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.FeedbackBuffer is called while the render mode is Gl.FEEDBACK, or if 
		/// Gl\.RenderMode is called with argument Gl.FEEDBACK before Gl.FeedbackBuffer is called at least once.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.FeedbackBuffer is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.LineStipple"/>
		/// <seealso cref="Gl.PassThrough"/>
		/// <seealso cref="Gl.PolygonMode"/>
		/// <seealso cref="Gl.RenderMode"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void FeedbackBuffer(FeedbackType type, params float[] buffer)
		{
			unsafe {
				fixed (float* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglFeedbackBuffer != null, "pglFeedbackBuffer not implemented");
					Delegates.pglFeedbackBuffer((Int32)buffer.Length, (Int32)type, p_buffer);
					LogCommand("glFeedbackBuffer", null, buffer.Length, type, buffer					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// establish a buffer for selection mode values
		/// </summary>
		/// <param name="buffer">
		/// Returns the selection data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="size"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.SelectBuffer is called while the render mode is Gl.SELECT, or if Gl\.RenderMode 
		/// is called with argument Gl.SELECT before Gl.SelectBuffer is called at least once.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.SelectBuffer is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.FeedbackBuffer"/>
		/// <seealso cref="Gl.InitNames"/>
		/// <seealso cref="Gl.LoadName"/>
		/// <seealso cref="Gl.PushName"/>
		/// <seealso cref="Gl.RenderMode"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void SelectBuffer(params UInt32[] buffer)
		{
			unsafe {
				fixed (UInt32* p_buffer = buffer)
				{
					Debug.Assert(Delegates.pglSelectBuffer != null, "pglSelectBuffer not implemented");
					Delegates.pglSelectBuffer((Int32)buffer.Length, p_buffer);
					LogCommand("glSelectBuffer", null, buffer.Length, buffer					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set rasterization mode
		/// </summary>
		/// <param name="mode">
		/// Specifies the rasterization mode. Three values are accepted: Gl.RENDER, Gl.SELECT, and Gl.FEEDBACK. The initial value is 
		/// Gl.RENDER.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not one of the three accepted values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl\.SelectBuffer is called while the render mode is Gl.SELECT, or if Gl.RenderMode 
		/// is called with argument Gl.SELECT before Gl\.SelectBuffer is called at least once.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl\.FeedbackBuffer is called while the render mode is Gl.FEEDBACK, or if 
		/// Gl.RenderMode is called with argument Gl.FEEDBACK before Gl\.FeedbackBuffer is called at least once.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.RenderMode is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.FeedbackBuffer"/>
		/// <seealso cref="Gl.InitNames"/>
		/// <seealso cref="Gl.LoadName"/>
		/// <seealso cref="Gl.PassThrough"/>
		/// <seealso cref="Gl.PushName"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static Int32 RenderMode(RenderingMode mode)
		{
			Int32 retValue;

			Debug.Assert(Delegates.pglRenderMode != null, "pglRenderMode not implemented");
			retValue = Delegates.pglRenderMode((Int32)mode);
			LogCommand("glRenderMode", retValue, mode			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// initialize the name stack
		/// </summary>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.InitNames is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadName"/>
		/// <seealso cref="Gl.PushName"/>
		/// <seealso cref="Gl.RenderMode"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void InitName()
		{
			Debug.Assert(Delegates.pglInitNames != null, "pglInitNames not implemented");
			Delegates.pglInitNames();
			LogCommand("glInitNames", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// load a name onto the name stack
		/// </summary>
		/// <param name="name">
		/// Specifies a name that will replace the top value on the name stack.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LoadName is called while the name stack is empty.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LoadName is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.InitNames"/>
		/// <seealso cref="Gl.PushName"/>
		/// <seealso cref="Gl.RenderMode"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadName(UInt32 name)
		{
			Debug.Assert(Delegates.pglLoadName != null, "pglLoadName not implemented");
			Delegates.pglLoadName(name);
			LogCommand("glLoadName", null, name			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// place a marker in the feedback buffer
		/// </summary>
		/// <param name="token">
		/// Specifies a marker value to be placed in the feedback buffer following a Gl.PASS_THROUGH_TOKEN.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PassThrough is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.FeedbackBuffer"/>
		/// <seealso cref="Gl.RenderMode"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PassThrough(float token)
		{
			Debug.Assert(Delegates.pglPassThrough != null, "pglPassThrough not implemented");
			Delegates.pglPassThrough(token);
			LogCommand("glPassThrough", null, token			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the name stack
		/// </summary>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushName is called while the name stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopName is called while the name stack is empty.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PushName or Gl\.PopName is executed between a call to Gl\.Begin and the 
		/// corresponding call to Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.InitNames"/>
		/// <seealso cref="Gl.LoadName"/>
		/// <seealso cref="Gl.RenderMode"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PopName()
		{
			Debug.Assert(Delegates.pglPopName != null, "pglPopName not implemented");
			Delegates.pglPopName();
			LogCommand("glPopName", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the name stack
		/// </summary>
		/// <param name="name">
		/// Specifies a name that will be pushed onto the name stack.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushName is called while the name stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopName is called while the name stack is empty.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PushName or Gl\.PopName is executed between a call to Gl\.Begin and the 
		/// corresponding call to Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.InitNames"/>
		/// <seealso cref="Gl.LoadName"/>
		/// <seealso cref="Gl.RenderMode"/>
		/// <seealso cref="Gl.SelectBuffer"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PushName(UInt32 name)
		{
			Debug.Assert(Delegates.pglPushName != null, "pglPushName not implemented");
			Delegates.pglPushName(name);
			LogCommand("glPushName", null, name			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify clear values for the accumulation buffer
		/// </summary>
		/// <param name="red">
		/// Specify the red, green, blue, and alpha values used when the accumulation buffer is cleared. The initial values are all 
		/// 0.
		/// </param>
		/// <param name="green">
		/// Specify the red, green, blue, and alpha values used when the accumulation buffer is cleared. The initial values are all 
		/// 0.
		/// </param>
		/// <param name="blue">
		/// Specify the red, green, blue, and alpha values used when the accumulation buffer is cleared. The initial values are all 
		/// 0.
		/// </param>
		/// <param name="alpha">
		/// Specify the red, green, blue, and alpha values used when the accumulation buffer is cleared. The initial values are all 
		/// 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ClearAccum is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Accum"/>
		/// <seealso cref="Gl.Clear"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ClearAccum(float red, float green, float blue, float alpha)
		{
			Debug.Assert(Delegates.pglClearAccum != null, "pglClearAccum not implemented");
			Delegates.pglClearAccum(red, green, blue, alpha);
			LogCommand("glClearAccum", null, red, green, blue, alpha			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the clear value for the color index buffers
		/// </summary>
		/// <param name="c">
		/// Specifies the index used when the color index buffers are cleared. The initial value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.ClearIndex is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Clear"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void ClearIndex(float c)
		{
			Debug.Assert(Delegates.pglClearIndex != null, "pglClearIndex not implemented");
			Delegates.pglClearIndex(c);
			LogCommand("glClearIndex", null, c			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// control the writing of individual bits in the color index buffers
		/// </summary>
		/// <param name="mask">
		/// Specifies a bit mask to enable and disable the writing of individual bits in the color index buffers. Initially, the 
		/// mask is all 1's.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.IndexMask is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorMask"/>
		/// <seealso cref="Gl.DepthMask"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.IndexPointer"/>
		/// <seealso cref="Gl.StencilMask"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void IndexMask(UInt32 mask)
		{
			Debug.Assert(Delegates.pglIndexMask != null, "pglIndexMask not implemented");
			Delegates.pglIndexMask(mask);
			LogCommand("glIndexMask", null, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// operate on the accumulation buffer
		/// </summary>
		/// <param name="op">
		/// Specifies the accumulation buffer operation. Symbolic constants Gl.ACCUM, Gl.LOAD, Gl.ADD, Gl.MULT, and Gl.RETURN are 
		/// accepted.
		/// </param>
		/// <param name="value">
		/// Specifies a floating-point value used in the accumulation buffer operation. <paramref name="op"/> determines how 
		/// <paramref name="value"/> is used.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="op"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if there is no accumulation buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Accum is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.ClearAccum"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilOp"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Accum(AccumOp op, float value)
		{
			Debug.Assert(Delegates.pglAccum != null, "pglAccum not implemented");
			Delegates.pglAccum((Int32)op, value);
			LogCommand("glAccum", null, op, value			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the server attribute stack
		/// </summary>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushAttrib is called while the attribute stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopAttrib is called while the attribute stack is empty.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PushAttrib or Gl\.PopAttrib is executed between the execution of Gl\.Begin and 
		/// the corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetClipPlane"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetLight"/>
		/// <seealso cref="Gl.GetMap"/>
		/// <seealso cref="Gl.GetMaterial"/>
		/// <seealso cref="Gl.GetPixelMap"/>
		/// <seealso cref="Gl.GetPolygonStipple"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexEnv"/>
		/// <seealso cref="Gl.GetTexGen"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PopAttrib()
		{
			Debug.Assert(Delegates.pglPopAttrib != null, "pglPopAttrib not implemented");
			Delegates.pglPopAttrib();
			LogCommand("glPopAttrib", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the server attribute stack
		/// </summary>
		/// <param name="mask">
		/// Specifies a mask that indicates which attributes to save. Values for <paramref name="mask"/> are listed below.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushAttrib is called while the attribute stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopAttrib is called while the attribute stack is empty.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PushAttrib or Gl\.PopAttrib is executed between the execution of Gl\.Begin and 
		/// the corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Get"/>
		/// <seealso cref="Gl.GetClipPlane"/>
		/// <seealso cref="Gl.GetError"/>
		/// <seealso cref="Gl.GetLight"/>
		/// <seealso cref="Gl.GetMap"/>
		/// <seealso cref="Gl.GetMaterial"/>
		/// <seealso cref="Gl.GetPixelMap"/>
		/// <seealso cref="Gl.GetPolygonStipple"/>
		/// <seealso cref="Gl.GetString"/>
		/// <seealso cref="Gl.GetTexEnv"/>
		/// <seealso cref="Gl.GetTexGen"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.GetTexLevelParameter"/>
		/// <seealso cref="Gl.GetTexParameter"/>
		/// <seealso cref="Gl.IsEnabled"/>
		/// <seealso cref="Gl.PushClientAttrib"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PushAttrib(AttribMask mask)
		{
			Debug.Assert(Delegates.pglPushAttrib != null, "pglPushAttrib not implemented");
			Delegates.pglPushAttrib((UInt32)mask);
			LogCommand("glPushAttrib", null, mask			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants Gl.MAP1_VERTEX_3, Gl.MAP1_VERTEX_4, 
		/// Gl.MAP1_INDEX, Gl.MAP1_COLOR_4, Gl.MAP1_NORMAL, Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, 
		/// Gl.MAP1_TEXTURE_COORD_3, and Gl.MAP1_TEXTURE_COORD_4 are accepted.
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specified by this command.
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specified by this command.
		/// </param>
		/// <param name="stride">
		/// Specifies the number of floats or doubles between the beginning of one control point and the beginning of the next one 
		/// in the data structure referenced in <paramref name="points"/>. This allows control points to be embedded in arbitrary 
		/// data structures. The only constraint is that the values for a particular control point must occupy contiguous memory 
		/// locations.
		/// </param>
		/// <param name="order">
		/// Specifies the number of control points. Must be positive.
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is less than the number of values in a control point.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="order"/> is less than 1 or greater than the return value of 
		/// Gl.MAX_EVAL_ORDER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map1 is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map1 is called and the value of Gl.ACTIVE_TEXTURE is not Gl.TEXTURE0.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map1(MapTarget target, double u1, double u2, Int32 stride, Int32 order, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMap1d != null, "pglMap1d not implemented");
					Delegates.pglMap1d((Int32)target, u1, u2, stride, order, p_points);
					LogCommand("glMap1d", null, target, u1, u2, stride, order, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants Gl.MAP1_VERTEX_3, Gl.MAP1_VERTEX_4, 
		/// Gl.MAP1_INDEX, Gl.MAP1_COLOR_4, Gl.MAP1_NORMAL, Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, 
		/// Gl.MAP1_TEXTURE_COORD_3, and Gl.MAP1_TEXTURE_COORD_4 are accepted.
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specified by this command.
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord1, to u^, the variable that is evaluated by the equations 
		/// specified by this command.
		/// </param>
		/// <param name="stride">
		/// Specifies the number of floats or doubles between the beginning of one control point and the beginning of the next one 
		/// in the data structure referenced in <paramref name="points"/>. This allows control points to be embedded in arbitrary 
		/// data structures. The only constraint is that the values for a particular control point must occupy contiguous memory 
		/// locations.
		/// </param>
		/// <param name="order">
		/// Specifies the number of control points. Must be positive.
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="stride"/> is less than the number of values in a control point.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="order"/> is less than 1 or greater than the return value of 
		/// Gl.MAX_EVAL_ORDER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map1 is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map1 is called and the value of Gl.ACTIVE_TEXTURE is not Gl.TEXTURE0.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map1(MapTarget target, float u1, float u2, Int32 stride, Int32 order, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMap1f != null, "pglMap1f not implemented");
					Delegates.pglMap1f((Int32)target, u1, u2, stride, order, p_points);
					LogCommand("glMap1f", null, target, u1, u2, stride, order, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a two-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants Gl.MAP2_VERTEX_3, Gl.MAP2_VERTEX_4, 
		/// Gl.MAP2_INDEX, Gl.MAP2_COLOR_4, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2, 
		/// Gl.MAP2_TEXTURE_COORD_3, and Gl.MAP2_TEXTURE_COORD_4 are accepted.
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1.
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1.
		/// </param>
		/// <param name="ustride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri+1⁢j, where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrary data structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memory locations. The initial value of <paramref name="ustride"/> is 0.
		/// </param>
		/// <param name="uorder">
		/// Specifies the dimension of the control point array in the u axis. Must be positive. The initial value is 1.
		/// </param>
		/// <param name="v1">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1.
		/// </param>
		/// <param name="v2">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1.
		/// </param>
		/// <param name="vstride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri⁡j+1, where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrary data structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memory locations. The initial value of <paramref name="vstride"/> is 0.
		/// </param>
		/// <param name="vorder">
		/// Specifies the dimension of the control point array in the v axis. Must be positive. The initial value is 1.
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>, or if <paramref name="v1"/> is 
		/// equal to <paramref name="v2"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="ustride"/> or <paramref name="vstride"/> is less than the number 
		/// of values in a control point.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="uorder"/> or <paramref name="vorder"/> is less than 1 or greater 
		/// than the return value of Gl.MAX_EVAL_ORDER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map2 is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map2 is called and the value of Gl.ACTIVE_TEXTURE is not Gl.TEXTURE0.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map2(MapTarget target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double[] points)
		{
			unsafe {
				fixed (double* p_points = points)
				{
					Debug.Assert(Delegates.pglMap2d != null, "pglMap2d not implemented");
					Delegates.pglMap2d((Int32)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					LogCommand("glMap2d", null, target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a two-dimensional evaluator
		/// </summary>
		/// <param name="target">
		/// Specifies the kind of values that are generated by the evaluator. Symbolic constants Gl.MAP2_VERTEX_3, Gl.MAP2_VERTEX_4, 
		/// Gl.MAP2_INDEX, Gl.MAP2_COLOR_4, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2, 
		/// Gl.MAP2_TEXTURE_COORD_3, and Gl.MAP2_TEXTURE_COORD_4 are accepted.
		/// </param>
		/// <param name="u1">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1.
		/// </param>
		/// <param name="u2">
		/// Specify a linear mapping of u, as presented to Gl\.EvalCoord2, to u^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="u1"/> is 0 and <paramref name="u2"/> is 1.
		/// </param>
		/// <param name="ustride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri+1⁢j, where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrary data structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memory locations. The initial value of <paramref name="ustride"/> is 0.
		/// </param>
		/// <param name="uorder">
		/// Specifies the dimension of the control point array in the u axis. Must be positive. The initial value is 1.
		/// </param>
		/// <param name="v1">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1.
		/// </param>
		/// <param name="v2">
		/// Specify a linear mapping of v, as presented to Gl\.EvalCoord2, to v^, one of the two variables that are evaluated by the 
		/// equations specified by this command. Initially, <paramref name="v1"/> is 0 and <paramref name="v2"/> is 1.
		/// </param>
		/// <param name="vstride">
		/// Specifies the number of floats or doubles between the beginning of control point Rij and the beginning of control point 
		/// Ri⁡j+1, where i and j are the u and v control point indices, respectively. This allows control points to be embedded in 
		/// arbitrary data structures. The only constraint is that the values for a particular control point must occupy contiguous 
		/// memory locations. The initial value of <paramref name="vstride"/> is 0.
		/// </param>
		/// <param name="vorder">
		/// Specifies the dimension of the control point array in the v axis. Must be positive. The initial value is 1.
		/// </param>
		/// <param name="points">
		/// Specifies a pointer to the array of control points.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="u1"/> is equal to <paramref name="u2"/>, or if <paramref name="v1"/> is 
		/// equal to <paramref name="v2"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="ustride"/> or <paramref name="vstride"/> is less than the number 
		/// of values in a control point.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="uorder"/> or <paramref name="vorder"/> is less than 1 or greater 
		/// than the return value of Gl.MAX_EVAL_ORDER.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map2 is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Map2 is called and the value of Gl.ACTIVE_TEXTURE is not Gl.TEXTURE0.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Map2(MapTarget target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float[] points)
		{
			unsafe {
				fixed (float* p_points = points)
				{
					Debug.Assert(Delegates.pglMap2f != null, "pglMap2f not implemented");
					Delegates.pglMap2f((Int32)target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, p_points);
					LogCommand("glMap2f", null, target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one- or two-dimensional mesh
		/// </summary>
		/// <param name="un">
		/// Specifies the number of partitions in the grid range interval [<paramref name="u1"/>, <paramref name="u2"/>]. Must be 
		/// positive.
		/// </param>
		/// <param name="u1">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <param name="u2">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="un"/> or <paramref name="vn"/> is not positive.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MapGrid is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MapGrid1(Int32 un, double u1, double u2)
		{
			Debug.Assert(Delegates.pglMapGrid1d != null, "pglMapGrid1d not implemented");
			Delegates.pglMapGrid1d(un, u1, u2);
			LogCommand("glMapGrid1d", null, un, u1, u2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one- or two-dimensional mesh
		/// </summary>
		/// <param name="un">
		/// Specifies the number of partitions in the grid range interval [<paramref name="u1"/>, <paramref name="u2"/>]. Must be 
		/// positive.
		/// </param>
		/// <param name="u1">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <param name="u2">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="un"/> or <paramref name="vn"/> is not positive.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MapGrid is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MapGrid1(Int32 un, float u1, float u2)
		{
			Debug.Assert(Delegates.pglMapGrid1f != null, "pglMapGrid1f not implemented");
			Delegates.pglMapGrid1f(un, u1, u2);
			LogCommand("glMapGrid1f", null, un, u1, u2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one- or two-dimensional mesh
		/// </summary>
		/// <param name="un">
		/// Specifies the number of partitions in the grid range interval [<paramref name="u1"/>, <paramref name="u2"/>]. Must be 
		/// positive.
		/// </param>
		/// <param name="u1">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <param name="u2">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <param name="vn">
		/// Specifies the number of partitions in the grid range interval [<paramref name="v1"/>, <paramref name="v2"/>] 
		/// (Gl.MapGrid2 only).
		/// </param>
		/// <param name="v1">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (Gl.MapGrid2 only).
		/// </param>
		/// <param name="v2">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (Gl.MapGrid2 only).
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="un"/> or <paramref name="vn"/> is not positive.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MapGrid is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MapGrid2(Int32 un, double u1, double u2, Int32 vn, double v1, double v2)
		{
			Debug.Assert(Delegates.pglMapGrid2d != null, "pglMapGrid2d not implemented");
			Delegates.pglMapGrid2d(un, u1, u2, vn, v1, v2);
			LogCommand("glMapGrid2d", null, un, u1, u2, vn, v1, v2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// define a one- or two-dimensional mesh
		/// </summary>
		/// <param name="un">
		/// Specifies the number of partitions in the grid range interval [<paramref name="u1"/>, <paramref name="u2"/>]. Must be 
		/// positive.
		/// </param>
		/// <param name="u1">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <param name="u2">
		/// Specify the mappings for integer grid domain values i=0 and i=un.
		/// </param>
		/// <param name="vn">
		/// Specifies the number of partitions in the grid range interval [<paramref name="v1"/>, <paramref name="v2"/>] 
		/// (Gl.MapGrid2 only).
		/// </param>
		/// <param name="v1">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (Gl.MapGrid2 only).
		/// </param>
		/// <param name="v2">
		/// Specify the mappings for integer grid domain values j=0 and j=vn (Gl.MapGrid2 only).
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="un"/> or <paramref name="vn"/> is not positive.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MapGrid is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MapGrid2(Int32 un, float u1, float u2, Int32 vn, float v1, float v2)
		{
			Debug.Assert(Delegates.pglMapGrid2f != null, "pglMapGrid2f not implemented");
			Delegates.pglMapGrid2f(un, u1, u2, vn, v1, v2);
			LogCommand("glMapGrid2f", null, un, u1, u2, vn, v1, v2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord1(double u)
		{
			Debug.Assert(Delegates.pglEvalCoord1d != null, "pglEvalCoord1d not implemented");
			Delegates.pglEvalCoord1d(u);
			LogCommand("glEvalCoord1d", null, u			);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord1(double[] u)
		{
			unsafe {
				fixed (double* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord1dv != null, "pglEvalCoord1dv not implemented");
					Delegates.pglEvalCoord1dv(p_u);
					LogCommand("glEvalCoord1dv", null, u					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord1(float u)
		{
			Debug.Assert(Delegates.pglEvalCoord1f != null, "pglEvalCoord1f not implemented");
			Delegates.pglEvalCoord1f(u);
			LogCommand("glEvalCoord1f", null, u			);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord1(float[] u)
		{
			unsafe {
				fixed (float* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord1fv != null, "pglEvalCoord1fv not implemented");
					Delegates.pglEvalCoord1fv(p_u);
					LogCommand("glEvalCoord1fv", null, u					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <param name="v">
		/// Specifies a value that is the domain coordinate v to the basis function defined in a previous Gl\.Map2 command. This 
		/// argument is not present in a Gl.EvalCoord1 command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord2(double u, double v)
		{
			Debug.Assert(Delegates.pglEvalCoord2d != null, "pglEvalCoord2d not implemented");
			Delegates.pglEvalCoord2d(u, v);
			LogCommand("glEvalCoord2d", null, u, v			);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord2(double[] u)
		{
			unsafe {
				fixed (double* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord2dv != null, "pglEvalCoord2dv not implemented");
					Delegates.pglEvalCoord2dv(p_u);
					LogCommand("glEvalCoord2dv", null, u					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <param name="v">
		/// Specifies a value that is the domain coordinate v to the basis function defined in a previous Gl\.Map2 command. This 
		/// argument is not present in a Gl.EvalCoord1 command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord2(float u, float v)
		{
			Debug.Assert(Delegates.pglEvalCoord2f != null, "pglEvalCoord2f not implemented");
			Delegates.pglEvalCoord2f(u, v);
			LogCommand("glEvalCoord2f", null, u, v			);
		}

		/// <summary>
		/// evaluate enabled one- and two-dimensional maps
		/// </summary>
		/// <param name="u">
		/// Specifies a value that is the domain coordinate u to the basis function defined in a previous Gl\.Map1 or Gl\.Map2 
		/// command.
		/// </param>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.Color"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Index"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		/// <seealso cref="Gl.Normal"/>
		/// <seealso cref="Gl.TexCoord"/>
		/// <seealso cref="Gl.Vertex"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalCoord2(float[] u)
		{
			unsafe {
				fixed (float* p_u = u)
				{
					Debug.Assert(Delegates.pglEvalCoord2fv != null, "pglEvalCoord2fv not implemented");
					Delegates.pglEvalCoord2fv(p_u);
					LogCommand("glEvalCoord2fv", null, u					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// compute a one- or two-dimensional grid of points or lines
		/// </summary>
		/// <param name="mode">
		/// In Gl.EvalMesh1, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic constants Gl.POINT and 
		/// Gl.LINE are accepted.
		/// </param>
		/// <param name="i1">
		/// Specify the first and last integer values for grid domain variable i.
		/// </param>
		/// <param name="i2">
		/// Specify the first and last integer values for grid domain variable i.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.EvalMesh is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalMesh1(MeshMode1 mode, Int32 i1, Int32 i2)
		{
			Debug.Assert(Delegates.pglEvalMesh1 != null, "pglEvalMesh1 not implemented");
			Delegates.pglEvalMesh1((Int32)mode, i1, i2);
			LogCommand("glEvalMesh1", null, mode, i1, i2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate and evaluate a single point in a mesh
		/// </summary>
		/// <param name="i">
		/// Specifies the integer value for grid domain variable i.
		/// </param>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalPoint1(Int32 i)
		{
			Debug.Assert(Delegates.pglEvalPoint1 != null, "pglEvalPoint1 not implemented");
			Delegates.pglEvalPoint1(i);
			LogCommand("glEvalPoint1", null, i			);
		}

		/// <summary>
		/// compute a one- or two-dimensional grid of points or lines
		/// </summary>
		/// <param name="mode">
		/// In Gl.EvalMesh1, specifies whether to compute a one-dimensional mesh of points or lines. Symbolic constants Gl.POINT and 
		/// Gl.LINE are accepted.
		/// </param>
		/// <param name="i1">
		/// Specify the first and last integer values for grid domain variable i.
		/// </param>
		/// <param name="i2">
		/// Specify the first and last integer values for grid domain variable i.
		/// </param>
		/// <param name="j1">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <param name="j2">
		/// A <see cref="T:Int32"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.EvalMesh is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Begin"/>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalPoint"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalMesh2(MeshMode2 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2)
		{
			Debug.Assert(Delegates.pglEvalMesh2 != null, "pglEvalMesh2 not implemented");
			Delegates.pglEvalMesh2((Int32)mode, i1, i2, j1, j2);
			LogCommand("glEvalMesh2", null, mode, i1, i2, j1, j2			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// generate and evaluate a single point in a mesh
		/// </summary>
		/// <param name="i">
		/// Specifies the integer value for grid domain variable i.
		/// </param>
		/// <param name="j">
		/// Specifies the integer value for grid domain variable j (Gl.EvalPoint2 only).
		/// </param>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.EvalMesh"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		/// <seealso cref="Gl.MapGrid"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void EvalPoint2(Int32 i, Int32 j)
		{
			Debug.Assert(Delegates.pglEvalPoint2 != null, "pglEvalPoint2 not implemented");
			Delegates.pglEvalPoint2(i, j);
			LogCommand("glEvalPoint2", null, i, j			);
		}

		/// <summary>
		/// specify the alpha test function
		/// </summary>
		/// <param name="func">
		/// Specifies the alpha comparison function. Symbolic constants Gl.NEVER, Gl.LESS, Gl.EQUAL, Gl.LEQUAL, Gl.GREATER, 
		/// Gl.NOTEQUAL, Gl.GEQUAL, and Gl.ALWAYS are accepted. The initial value is Gl.ALWAYS.
		/// </param>
		/// <param name="ref">
		/// Specifies the reference value that incoming alpha values are compared to. This value is clamped to the range 01, where 0 
		/// represents the lowest possible alpha value and 1 the highest possible value. The initial reference value is 0.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="func"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.AlphaFunc is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.Clear"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.Enable"/>
		/// <seealso cref="Gl.StencilFunc"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void AlphaFunc(AlphaFunction func, float @ref)
		{
			Debug.Assert(Delegates.pglAlphaFunc != null, "pglAlphaFunc not implemented");
			Delegates.pglAlphaFunc((Int32)func, @ref);
			LogCommand("glAlphaFunc", null, func, @ref			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify the pixel zoom factors
		/// </summary>
		/// <param name="xfactor">
		/// Specify the x and y zoom factors for pixel write operations.
		/// </param>
		/// <param name="yfactor">
		/// Specify the x and y zoom factors for pixel write operations.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelZoom is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DrawPixels"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelZoom(float xfactor, float yfactor)
		{
			Debug.Assert(Delegates.pglPixelZoom != null, "pglPixelZoom not implemented");
			Delegates.pglPixelZoom(xfactor, yfactor);
			LogCommand("glPixelZoom", null, xfactor, yfactor			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set pixel transfer modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the pixel transfer parameter to be set. Must be one of the following: Gl.MAP_COLOR, 
		/// Gl.MAP_STENCIL, Gl.INDEX_SHIFT, Gl.INDEX_OFFSET, Gl.RED_SCALE, Gl.RED_BIAS, Gl.GREEN_SCALE, Gl.GREEN_BIAS, 
		/// Gl.BLUE_SCALE, Gl.BLUE_BIAS, Gl.ALPHA_SCALE, Gl.ALPHA_BIAS, Gl.DEPTH_SCALE, or Gl.DEPTH_BIAS.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelTransfer is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelTransfer(PixelTransferParameter pname, float param)
		{
			Debug.Assert(Delegates.pglPixelTransferf != null, "pglPixelTransferf not implemented");
			Delegates.pglPixelTransferf((Int32)pname, param);
			LogCommand("glPixelTransferf", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set pixel transfer modes
		/// </summary>
		/// <param name="pname">
		/// Specifies the symbolic name of the pixel transfer parameter to be set. Must be one of the following: Gl.MAP_COLOR, 
		/// Gl.MAP_STENCIL, Gl.INDEX_SHIFT, Gl.INDEX_OFFSET, Gl.RED_SCALE, Gl.RED_BIAS, Gl.GREEN_SCALE, Gl.GREEN_BIAS, 
		/// Gl.BLUE_SCALE, Gl.BLUE_BIAS, Gl.ALPHA_SCALE, Gl.ALPHA_BIAS, Gl.DEPTH_SCALE, or Gl.DEPTH_BIAS.
		/// </param>
		/// <param name="param">
		/// Specifies the value that <paramref name="pname"/> is set to.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelTransfer is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.NewList"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelTransfer(PixelTransferParameter pname, Int32 param)
		{
			Debug.Assert(Delegates.pglPixelTransferi != null, "pglPixelTransferi not implemented");
			Delegates.pglPixelTransferi((Int32)pname, param);
			LogCommand("glPixelTransferi", null, pname, param			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="mapsize">
		/// Specifies the size of the map being defined.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="mapsize"/> is less than one or larger than Gl.MAX_PIXEL_MAP_TABLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="map"/> is Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, or Gl.PIXEL_MAP_I_TO_A, and <paramref name="mapsize"/> is 
		/// not a power of two.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, Int32 mapsize, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapfv != null, "pglPixelMapfv not implemented");
					Delegates.pglPixelMapfv((Int32)map, mapsize, p_values);
					LogCommand("glPixelMapfv", null, map, mapsize, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="mapsize"/> is less than one or larger than Gl.MAX_PIXEL_MAP_TABLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="map"/> is Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, or Gl.PIXEL_MAP_I_TO_A, and <paramref name="mapsize"/> is 
		/// not a power of two.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapfv != null, "pglPixelMapfv not implemented");
					Delegates.pglPixelMapfv((Int32)map, (Int32)values.Length, p_values);
					LogCommand("glPixelMapfv", null, map, values.Length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="mapsize">
		/// Specifies the size of the map being defined.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="mapsize"/> is less than one or larger than Gl.MAX_PIXEL_MAP_TABLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="map"/> is Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, or Gl.PIXEL_MAP_I_TO_A, and <paramref name="mapsize"/> is 
		/// not a power of two.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, Int32 mapsize, UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapuiv != null, "pglPixelMapuiv not implemented");
					Delegates.pglPixelMapuiv((Int32)map, mapsize, p_values);
					LogCommand("glPixelMapuiv", null, map, mapsize, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="mapsize"/> is less than one or larger than Gl.MAX_PIXEL_MAP_TABLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="map"/> is Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, or Gl.PIXEL_MAP_I_TO_A, and <paramref name="mapsize"/> is 
		/// not a power of two.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapuiv != null, "pglPixelMapuiv not implemented");
					Delegates.pglPixelMapuiv((Int32)map, (Int32)values.Length, p_values);
					LogCommand("glPixelMapuiv", null, map, values.Length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="mapsize">
		/// Specifies the size of the map being defined.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="mapsize"/> is less than one or larger than Gl.MAX_PIXEL_MAP_TABLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="map"/> is Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, or Gl.PIXEL_MAP_I_TO_A, and <paramref name="mapsize"/> is 
		/// not a power of two.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, Int32 mapsize, UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapusv != null, "pglPixelMapusv not implemented");
					Delegates.pglPixelMapusv((Int32)map, mapsize, p_values);
					LogCommand("glPixelMapusv", null, map, mapsize, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// set up pixel transfer maps
		/// </summary>
		/// <param name="map">
		/// Specifies a symbolic map name. Must be one of the following: Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, or Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="values">
		/// Specifies an array of <paramref name="mapsize"/> values.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="mapsize"/> is less than one or larger than Gl.MAX_PIXEL_MAP_TABLE.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="map"/> is Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, or Gl.PIXEL_MAP_I_TO_A, and <paramref name="mapsize"/> is 
		/// not a power of two.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.PixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_UNPACK_BUFFER target and <paramref name="values"/> is not evenly divisible into the number of bytes needed to 
		/// store in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.Histogram"/>
		/// <seealso cref="Gl.Minmax"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PixelMap(PixelMap map, UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglPixelMapusv != null, "pglPixelMapusv not implemented");
					Delegates.pglPixelMapusv((Int32)map, (Int32)values.Length, p_values);
					LogCommand("glPixelMapusv", null, map, values.Length, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// copy pixels in the frame buffer
		/// </summary>
		/// <param name="x">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="y">
		/// Specify the window coordinates of the lower left corner of the rectangular region of pixels to be copied.
		/// </param>
		/// <param name="width">
		/// Specify the dimensions of the rectangular region of pixels to be copied. Both must be nonnegative.
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the rectangular region of pixels to be copied. Both must be nonnegative.
		/// </param>
		/// <param name="type">
		/// Specifies whether color values, depth values, or stencil values are to be copied. Symbolic constants Gl.COLOR, Gl.DEPTH, 
		/// and Gl.STENCIL are accepted.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.DEPTH and there is no depth buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="type"/> is Gl.STENCIL and there is no stencil buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.CopyPixels is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.DrawBuffer"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.ReadBuffer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelCopyType type)
		{
			Debug.Assert(Delegates.pglCopyPixels != null, "pglCopyPixels not implemented");
			Delegates.pglCopyPixels(x, y, width, height, (Int32)type);
			LogCommand("glCopyPixels", null, x, y, width, height, type			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// write a block of pixels to the frame buffer
		/// </summary>
		/// <param name="width">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer.
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. Symbolic constants Gl.COLOR_INDEX, Gl.STENCIL_INDEX, Gl.DEPTH_COMPONENT, Gl.RGB, 
		/// Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA are accepted.
		/// </param>
		/// <param name="type">
		/// Specifies the data type for <paramref name="data"/>. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> or <paramref name="type"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not either 
		/// Gl.COLOR_INDEX or Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and there is no stencil buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.RGBA, 
		/// Gl.BGR, Gl.BGRA, Gl.LUMINANCE, or Gl.LUMINANCE_ALPHA, and the GL is in color index mode.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.DrawPixels is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void DrawPixels(Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels)
		{
			Debug.Assert(Delegates.pglDrawPixels != null, "pglDrawPixels not implemented");
			Delegates.pglDrawPixels(width, height, (Int32)format, (Int32)type, pixels);
			LogCommand("glDrawPixels", null, width, height, format, type, pixels			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// write a block of pixels to the frame buffer
		/// </summary>
		/// <param name="width">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer.
		/// </param>
		/// <param name="height">
		/// Specify the dimensions of the pixel rectangle to be written into the frame buffer.
		/// </param>
		/// <param name="format">
		/// Specifies the format of the pixel data. Symbolic constants Gl.COLOR_INDEX, Gl.STENCIL_INDEX, Gl.DEPTH_COMPONENT, Gl.RGB, 
		/// Gl.BGR, Gl.RGBA, Gl.BGRA, Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.LUMINANCE, and Gl.LUMINANCE_ALPHA are accepted.
		/// </param>
		/// <param name="type">
		/// Specifies the data type for <paramref name="data"/>. Symbolic constants Gl.UNSIGNED_BYTE, Gl.BYTE, Gl.BITMAP, 
		/// Gl.UNSIGNED_SHORT, Gl.SHORT, Gl.UNSIGNED_INT, Gl.INT, Gl.FLOAT, Gl.UNSIGNED_BYTE_3_3_2, Gl.UNSIGNED_BYTE_2_3_3_REV, 
		/// Gl.UNSIGNED_SHORT_5_6_5, Gl.UNSIGNED_SHORT_5_6_5_REV, Gl.UNSIGNED_SHORT_4_4_4_4, Gl.UNSIGNED_SHORT_4_4_4_4_REV, 
		/// Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, Gl.UNSIGNED_INT_8_8_8_8_REV, 
		/// Gl.UNSIGNED_INT_10_10_10_2, and Gl.UNSIGNED_INT_2_10_10_10_REV are accepted.
		/// </param>
		/// <param name="pixels">
		/// A <see cref="T:Object"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="format"/> or <paramref name="type"/> is not one of the accepted values.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="type"/> is Gl.BITMAP and <paramref name="format"/> is not either 
		/// Gl.COLOR_INDEX or Gl.STENCIL_INDEX.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if either <paramref name="width"/> or <paramref name="height"/> is negative.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.STENCIL_INDEX and there is no stencil buffer.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is Gl.RED, Gl.GREEN, Gl.BLUE, Gl.ALPHA, Gl.RGB, Gl.RGBA, 
		/// Gl.BGR, Gl.BGRA, Gl.LUMINANCE, or Gl.LUMINANCE_ALPHA, and the GL is in color index mode.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is one of Gl.UNSIGNED_BYTE_3_3_2, 
		/// Gl.UNSIGNED_BYTE_2_3_3_REV, Gl.UNSIGNED_SHORT_5_6_5, or Gl.UNSIGNED_SHORT_5_6_5_REV and <paramref name="format"/> is not 
		/// Gl.RGB.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if <paramref name="format"/> is one of Gl.UNSIGNED_SHORT_4_4_4_4, 
		/// Gl.UNSIGNED_SHORT_4_4_4_4_REV, Gl.UNSIGNED_SHORT_5_5_5_1, Gl.UNSIGNED_SHORT_1_5_5_5_REV, Gl.UNSIGNED_INT_8_8_8_8, 
		/// Gl.UNSIGNED_INT_8_8_8_8_REV, Gl.UNSIGNED_INT_10_10_10_2, or Gl.UNSIGNED_INT_2_10_10_10_REV and <paramref name="format"/> 
		/// is neither Gl.RGBA nor Gl.BGRA.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and the 
		/// data would be unpacked from the buffer object such that the memory reads required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_UNPACK_BUFFER target and 
		/// <paramref name="data"/> is not evenly divisible into the number of bytes needed to store in memory a datum indicated by 
		/// <paramref name="type"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.DrawPixels is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.AlphaFunc"/>
		/// <seealso cref="Gl.BlendFunc"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.DepthFunc"/>
		/// <seealso cref="Gl.LogicOp"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PixelZoom"/>
		/// <seealso cref="Gl.RasterPos"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.Scissor"/>
		/// <seealso cref="Gl.StencilFunc"/>
		/// <seealso cref="Gl.WindowPos"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void DrawPixels(Int32 width, Int32 height, PixelFormat format, PixelType type, Object pixels)
		{
			GCHandle pin_pixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try {
				DrawPixels(width, height, format, type, pin_pixels.AddrOfPinnedObject());
			} finally {
				pin_pixels.Free();
			}
		}

		/// <summary>
		/// return the coefficients of the specified clipping plane
		/// </summary>
		/// <param name="plane">
		/// Specifies a clipping plane. The number of clipping planes depends on the implementation, but at least six clipping 
		/// planes are supported. They are identified by symbolic names of the form Gl.CLIP_PLANEi where i ranges from 0 to the 
		/// value of Gl.MAX_CLIP_PLANES - 1.
		/// </param>
		/// <param name="equation">
		/// Returns four double-precision values that are the coefficients of the plane equation of <paramref name="plane"/> in eye 
		/// coordinates. The initial value is (0, 0, 0, 0).
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="plane"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetClipPlane is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ClipPlane"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetClipPlane(ClipPlaneName plane, [Out] double[] equation)
		{
			unsafe {
				fixed (double* p_equation = equation)
				{
					Debug.Assert(Delegates.pglGetClipPlane != null, "pglGetClipPlane not implemented");
					Delegates.pglGetClipPlane((Int32)plane, p_equation);
					LogCommand("glGetClipPlane", null, plane, equation					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return light source parameter values
		/// </summary>
		/// <param name="light">
		/// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are 
		/// supported. They are identified by symbolic names of the form Gl.LIGHTi where i ranges from 0 to the value of 
		/// Gl.MAX_LIGHTS - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a light source parameter for <paramref name="light"/>. Accepted symbolic names are Gl.AMBIENT, Gl.DIFFUSE, 
		/// Gl.SPECULAR, Gl.POSITION, Gl.SPOT_DIRECTION, Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, Gl.CONSTANT_ATTENUATION, 
		/// Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetLight is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetLight(LightName light, LightParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightfv != null, "pglGetLightfv not implemented");
					Delegates.pglGetLightfv((Int32)light, (Int32)pname, p_params);
					LogCommand("glGetLightfv", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return light source parameter values
		/// </summary>
		/// <param name="light">
		/// Specifies a light source. The number of possible lights depends on the implementation, but at least eight lights are 
		/// supported. They are identified by symbolic names of the form Gl.LIGHTi where i ranges from 0 to the value of 
		/// Gl.MAX_LIGHTS - 1.
		/// </param>
		/// <param name="pname">
		/// Specifies a light source parameter for <paramref name="light"/>. Accepted symbolic names are Gl.AMBIENT, Gl.DIFFUSE, 
		/// Gl.SPECULAR, Gl.POSITION, Gl.SPOT_DIRECTION, Gl.SPOT_EXPONENT, Gl.SPOT_CUTOFF, Gl.CONSTANT_ATTENUATION, 
		/// Gl.LINEAR_ATTENUATION, and Gl.QUADRATIC_ATTENUATION.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="light"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetLight is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Light"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetLight(LightName light, LightParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetLightiv != null, "pglGetLightiv not implemented");
					Delegates.pglGetLightiv((Int32)light, (Int32)pname, p_params);
					LogCommand("glGetLightiv", null, light, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are Gl.MAP1_COLOR_4, Gl.MAP1_INDEX, Gl.MAP1_NORMAL, 
		/// Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, Gl.MAP1_TEXTURE_COORD_3, Gl.MAP1_TEXTURE_COORD_4, Gl.MAP1_VERTEX_3, 
		/// Gl.MAP1_VERTEX_4, Gl.MAP2_COLOR_4, Gl.MAP2_INDEX, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2, 
		/// Gl.MAP2_TEXTURE_COORD_3, Gl.MAP2_TEXTURE_COORD_4, Gl.MAP2_VERTEX_3, and Gl.MAP2_VERTEX_4.
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names Gl.COEFF, Gl.ORDER, and Gl.DOMAIN are accepted.
		/// </param>
		/// <param name="v">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="target"/> or <paramref name="query"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMap(MapTarget target, GetMapQuery query, [Out] double[] v)
		{
			unsafe {
				fixed (double* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapdv != null, "pglGetMapdv not implemented");
					Delegates.pglGetMapdv((Int32)target, (Int32)query, p_v);
					LogCommand("glGetMapdv", null, target, query, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are Gl.MAP1_COLOR_4, Gl.MAP1_INDEX, Gl.MAP1_NORMAL, 
		/// Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, Gl.MAP1_TEXTURE_COORD_3, Gl.MAP1_TEXTURE_COORD_4, Gl.MAP1_VERTEX_3, 
		/// Gl.MAP1_VERTEX_4, Gl.MAP2_COLOR_4, Gl.MAP2_INDEX, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2, 
		/// Gl.MAP2_TEXTURE_COORD_3, Gl.MAP2_TEXTURE_COORD_4, Gl.MAP2_VERTEX_3, and Gl.MAP2_VERTEX_4.
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names Gl.COEFF, Gl.ORDER, and Gl.DOMAIN are accepted.
		/// </param>
		/// <param name="v">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="target"/> or <paramref name="query"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMap(MapTarget target, GetMapQuery query, [Out] float[] v)
		{
			unsafe {
				fixed (float* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapfv != null, "pglGetMapfv not implemented");
					Delegates.pglGetMapfv((Int32)target, (Int32)query, p_v);
					LogCommand("glGetMapfv", null, target, query, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return evaluator parameters
		/// </summary>
		/// <param name="target">
		/// Specifies the symbolic name of a map. Accepted values are Gl.MAP1_COLOR_4, Gl.MAP1_INDEX, Gl.MAP1_NORMAL, 
		/// Gl.MAP1_TEXTURE_COORD_1, Gl.MAP1_TEXTURE_COORD_2, Gl.MAP1_TEXTURE_COORD_3, Gl.MAP1_TEXTURE_COORD_4, Gl.MAP1_VERTEX_3, 
		/// Gl.MAP1_VERTEX_4, Gl.MAP2_COLOR_4, Gl.MAP2_INDEX, Gl.MAP2_NORMAL, Gl.MAP2_TEXTURE_COORD_1, Gl.MAP2_TEXTURE_COORD_2, 
		/// Gl.MAP2_TEXTURE_COORD_3, Gl.MAP2_TEXTURE_COORD_4, Gl.MAP2_VERTEX_3, and Gl.MAP2_VERTEX_4.
		/// </param>
		/// <param name="query">
		/// Specifies which parameter to return. Symbolic names Gl.COEFF, Gl.ORDER, and Gl.DOMAIN are accepted.
		/// </param>
		/// <param name="v">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if either <paramref name="target"/> or <paramref name="query"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.EvalCoord"/>
		/// <seealso cref="Gl.Map1"/>
		/// <seealso cref="Gl.Map2"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMap(MapTarget target, GetMapQuery query, [Out] Int32[] v)
		{
			unsafe {
				fixed (Int32* p_v = v)
				{
					Debug.Assert(Delegates.pglGetMapiv != null, "pglGetMapiv not implemented");
					Delegates.pglGetMapiv((Int32)target, (Int32)query, p_v);
					LogCommand("glGetMapiv", null, target, query, v					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return material parameters
		/// </summary>
		/// <param name="face">
		/// Specifies which of the two materials is being queried. Gl.FRONT or Gl.BACK are accepted, representing the front and back 
		/// materials, respectively.
		/// </param>
		/// <param name="pname">
		/// Specifies the material parameter to return. Gl.AMBIENT, Gl.DIFFUSE, Gl.SPECULAR, Gl.EMISSION, Gl.SHININESS, and 
		/// Gl.COLOR_INDEXES are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMaterial is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMaterial(MaterialFace face, MaterialParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialfv != null, "pglGetMaterialfv not implemented");
					Delegates.pglGetMaterialfv((Int32)face, (Int32)pname, p_params);
					LogCommand("glGetMaterialfv", null, face, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return material parameters
		/// </summary>
		/// <param name="face">
		/// Specifies which of the two materials is being queried. Gl.FRONT or Gl.BACK are accepted, representing the front and back 
		/// materials, respectively.
		/// </param>
		/// <param name="pname">
		/// Specifies the material parameter to return. Gl.AMBIENT, Gl.DIFFUSE, Gl.SPECULAR, Gl.EMISSION, Gl.SHININESS, and 
		/// Gl.COLOR_INDEXES are accepted.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="face"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetMaterial is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Material"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetMaterial(MaterialFace face, MaterialParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetMaterialiv != null, "pglGetMaterialiv not implemented");
					Delegates.pglGetMaterialiv((Int32)face, (Int32)pname, p_params);
					LogCommand("glGetMaterialiv", null, face, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the specified pixel map
		/// </summary>
		/// <param name="map">
		/// Specifies the name of the pixel map to return. Accepted values are Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, and Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:float[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetPixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetHistogram"/>
		/// <seealso cref="Gl.GetMinmax"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPixelMap(PixelMap map, [Out] float[] values)
		{
			unsafe {
				fixed (float* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapfv != null, "pglGetPixelMapfv not implemented");
					Delegates.pglGetPixelMapfv((Int32)map, p_values);
					LogCommand("glGetPixelMapfv", null, map, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the specified pixel map
		/// </summary>
		/// <param name="map">
		/// Specifies the name of the pixel map to return. Accepted values are Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, and Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt32[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetPixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetHistogram"/>
		/// <seealso cref="Gl.GetMinmax"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPixelMap(PixelMap map, [Out] UInt32[] values)
		{
			unsafe {
				fixed (UInt32* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapuiv != null, "pglGetPixelMapuiv not implemented");
					Delegates.pglGetPixelMapuiv((Int32)map, p_values);
					LogCommand("glGetPixelMapuiv", null, map, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the specified pixel map
		/// </summary>
		/// <param name="map">
		/// Specifies the name of the pixel map to return. Accepted values are Gl.PIXEL_MAP_I_TO_I, Gl.PIXEL_MAP_S_TO_S, 
		/// Gl.PIXEL_MAP_I_TO_R, Gl.PIXEL_MAP_I_TO_G, Gl.PIXEL_MAP_I_TO_B, Gl.PIXEL_MAP_I_TO_A, Gl.PIXEL_MAP_R_TO_R, 
		/// Gl.PIXEL_MAP_G_TO_G, Gl.PIXEL_MAP_B_TO_B, and Gl.PIXEL_MAP_A_TO_A.
		/// </param>
		/// <param name="values">
		/// A <see cref="T:UInt16[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="map"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapfv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLfloat datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapuiv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLuint datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated by Gl.GetPixelMapusv if a non-zero buffer object name is bound to the 
		/// Gl.PIXEL_PACK_BUFFER target and <paramref name="data"/> is not evenly divisible into the number of bytes needed to store 
		/// in memory a GLushort datum.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetPixelMap is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ColorSubTable"/>
		/// <seealso cref="Gl.ColorTable"/>
		/// <seealso cref="Gl.ConvolutionFilter1D"/>
		/// <seealso cref="Gl.ConvolutionFilter2D"/>
		/// <seealso cref="Gl.CopyColorSubTable"/>
		/// <seealso cref="Gl.CopyColorTable"/>
		/// <seealso cref="Gl.CopyPixels"/>
		/// <seealso cref="Gl.CopyTexImage1D"/>
		/// <seealso cref="Gl.CopyTexImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage1D"/>
		/// <seealso cref="Gl.CopyTexSubImage2D"/>
		/// <seealso cref="Gl.CopyTexSubImage3D"/>
		/// <seealso cref="Gl.DrawPixels"/>
		/// <seealso cref="Gl.GetHistogram"/>
		/// <seealso cref="Gl.GetMinmax"/>
		/// <seealso cref="Gl.GetTexImage"/>
		/// <seealso cref="Gl.PixelMap"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.ReadPixels"/>
		/// <seealso cref="Gl.SeparableFilter2D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage1D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage2D"/>
		/// <seealso cref="Gl.TexImage3D"/>
		/// <seealso cref="Gl.TexSubImage1D"/>
		/// <seealso cref="Gl.TexSubImage2D"/>
		/// <seealso cref="Gl.TexSubImage3D"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPixelMap(PixelMap map, [Out] UInt16[] values)
		{
			unsafe {
				fixed (UInt16* p_values = values)
				{
					Debug.Assert(Delegates.pglGetPixelMapusv != null, "pglGetPixelMapusv not implemented");
					Delegates.pglGetPixelMapusv((Int32)map, p_values);
					LogCommand("glGetPixelMapusv", null, map, values					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return the polygon stipple pattern
		/// </summary>
		/// <param name="mask">
		/// A <see cref="T:byte[]"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// buffer object's data store is currently mapped.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if a non-zero buffer object name is bound to the Gl.PIXEL_PACK_BUFFER target and the 
		/// data would be packed to the buffer object such that the memory writes required would exceed the data store size.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetPolygonStipple is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.PixelStore"/>
		/// <seealso cref="Gl.PixelTransfer"/>
		/// <seealso cref="Gl.PolygonStipple"/>
		/// <seealso cref="Gl.ReadPixels"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetPolygonStipple([Out] byte[] mask)
		{
			unsafe {
				fixed (byte* p_mask = mask)
				{
					Debug.Assert(Delegates.pglGetPolygonStipple != null, "pglGetPolygonStipple not implemented");
					Delegates.pglGetPolygonStipple(p_mask);
					LogCommand("glGetPolygonStipple", null, mask					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL, or Gl.POINT_SPRITE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture environment parameter. Accepted values are Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_ENV_COLOR, Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, 
		/// Gl.SRC0_ALPHA, Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, 
		/// Gl.OPERAND1_ALPHA, Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexEnv is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.TexEnv"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnvfv != null, "pglGetTexEnvfv not implemented");
					Delegates.pglGetTexEnvfv((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetTexEnvfv", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture environment parameters
		/// </summary>
		/// <param name="target">
		/// Specifies a texture environment. May be Gl.TEXTURE_ENV, Gl.TEXTURE_FILTER_CONTROL, or Gl.POINT_SPRITE.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of a texture environment parameter. Accepted values are Gl.TEXTURE_ENV_MODE, 
		/// Gl.TEXTURE_ENV_COLOR, Gl.TEXTURE_LOD_BIAS, Gl.COMBINE_RGB, Gl.COMBINE_ALPHA, Gl.SRC0_RGB, Gl.SRC1_RGB, Gl.SRC2_RGB, 
		/// Gl.SRC0_ALPHA, Gl.SRC1_ALPHA, Gl.SRC2_ALPHA, Gl.OPERAND0_RGB, Gl.OPERAND1_RGB, Gl.OPERAND2_RGB, Gl.OPERAND0_ALPHA, 
		/// Gl.OPERAND1_ALPHA, Gl.OPERAND2_ALPHA, Gl.RGB_SCALE, Gl.ALPHA_SCALE, or Gl.COORD_REPLACE.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="target"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexEnv is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.TexEnv"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexEnv(TextureEnvTarget target, TextureEnvParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexEnviv != null, "pglGetTexEnviv not implemented");
					Delegates.pglGetTexEnviv((Int32)target, (Int32)pname, p_params);
					LogCommand("glGetTexEnviv", null, target, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture coordinate generation parameters
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the value(s) to be returned. Must be either Gl.TEXTURE_GEN_MODE or the name of one of the 
		/// texture generation plane equations: Gl.OBJECT_PLANE or Gl.EYE_PLANE.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="coord"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.TexGen"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] double[] @params)
		{
			unsafe {
				fixed (double* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGendv != null, "pglGetTexGendv not implemented");
					Delegates.pglGetTexGendv((Int32)coord, (Int32)pname, p_params);
					LogCommand("glGetTexGendv", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture coordinate generation parameters
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the value(s) to be returned. Must be either Gl.TEXTURE_GEN_MODE or the name of one of the 
		/// texture generation plane equations: Gl.OBJECT_PLANE or Gl.EYE_PLANE.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="coord"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.TexGen"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] float[] @params)
		{
			unsafe {
				fixed (float* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGenfv != null, "pglGetTexGenfv not implemented");
					Delegates.pglGetTexGenfv((Int32)coord, (Int32)pname, p_params);
					LogCommand("glGetTexGenfv", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// return texture coordinate generation parameters
		/// </summary>
		/// <param name="coord">
		/// Specifies a texture coordinate. Must be Gl.S, Gl.T, Gl.R, or Gl.Q.
		/// </param>
		/// <param name="pname">
		/// Specifies the symbolic name of the value(s) to be returned. Must be either Gl.TEXTURE_GEN_MODE or the name of one of the 
		/// texture generation plane equations: Gl.OBJECT_PLANE or Gl.EYE_PLANE.
		/// </param>
		/// <param name="params">
		/// Returns the requested data.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="coord"/> or <paramref name="pname"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.GetTexGen is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.ActiveTexture"/>
		/// <seealso cref="Gl.TexGen"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void GetTexGen(TextureCoordName coord, TextureGenParameter pname, [Out] Int32[] @params)
		{
			unsafe {
				fixed (Int32* p_params = @params)
				{
					Debug.Assert(Delegates.pglGetTexGeniv != null, "pglGetTexGeniv not implemented");
					Delegates.pglGetTexGeniv((Int32)coord, (Int32)pname, p_params);
					LogCommand("glGetTexGeniv", null, coord, pname, @params					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// determine if a name corresponds to a display list
		/// </summary>
		/// <param name="list">
		/// Specifies a potential display list name.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.IsList is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.CallList"/>
		/// <seealso cref="Gl.CallLists"/>
		/// <seealso cref="Gl.DeleteLists"/>
		/// <seealso cref="Gl.GenLists"/>
		/// <seealso cref="Gl.NewList"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static bool IsList(UInt32 list)
		{
			bool retValue;

			Debug.Assert(Delegates.pglIsList != null, "pglIsList not implemented");
			retValue = Delegates.pglIsList(list);
			LogCommand("glIsList", retValue, list			);
			DebugCheckErrors(retValue);

			return (retValue);
		}

		/// <summary>
		/// multiply the current matrix by a perspective matrix
		/// </summary>
		/// <param name="left">
		/// Specify the coordinates for the left and right vertical clipping planes.
		/// </param>
		/// <param name="right">
		/// Specify the coordinates for the left and right vertical clipping planes.
		/// </param>
		/// <param name="bottom">
		/// Specify the coordinates for the bottom and top horizontal clipping planes.
		/// </param>
		/// <param name="top">
		/// Specify the coordinates for the bottom and top horizontal clipping planes.
		/// </param>
		/// <param name="zNear">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zFar">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="nearVal"/> or <paramref name="farVal"/> is not positive, or if 
		/// <paramref name="left"/> = <paramref name="right"/>, or <paramref name="bottom"/> = <paramref name="top"/>, or <paramref 
		/// name="near"/> = <paramref name="far"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Frustum is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Ortho"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Frustum(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Debug.Assert(Delegates.pglFrustum != null, "pglFrustum not implemented");
			Delegates.pglFrustum(left, right, bottom, top, zNear, zFar);
			LogCommand("glFrustum", null, left, right, bottom, top, zNear, zFar			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// replace the current matrix with the identity matrix
		/// </summary>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LoadIdentity is executed between the execution of Gl\.Begin and the 
		/// corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadIdentity()
		{
			Debug.Assert(Delegates.pglLoadIdentity != null, "pglLoadIdentity not implemented");
			Delegates.pglLoadIdentity();
			LogCommand("glLoadIdentity", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// replace the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LoadMatrix is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixf != null, "pglLoadMatrixf not implemented");
					Delegates.pglLoadMatrixf(p_m);
					LogCommand("glLoadMatrixf", null, m					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// replace the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Specifies a pointer to 16 consecutive values, which are used as the elements of a 4×4 column-major matrix.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.LoadMatrix is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void LoadMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglLoadMatrixd != null, "pglLoadMatrixd not implemented");
					Delegates.pglLoadMatrixd(p_m);
					LogCommand("glLoadMatrixd", null, m					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// specify which matrix is the current matrix
		/// </summary>
		/// <param name="mode">
		/// Specifies which matrix stack is the target for subsequent matrix operations. Three values are accepted: Gl.MODELVIEW, 
		/// Gl.PROJECTION, and Gl.TEXTURE. The initial value is Gl.MODELVIEW. Additionally, if the ARB_imaging extension is 
		/// supported, Gl.COLOR is also accepted.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_ENUM is generated if <paramref name="mode"/> is not an accepted value.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MatrixMode is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PopMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MatrixMode(MatrixMode mode)
		{
			Debug.Assert(Delegates.pglMatrixMode != null, "pglMatrixMode not implemented");
			Delegates.pglMatrixMode((Int32)mode);
			LogCommand("glMatrixMode", null, mode			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MultMatrix is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultMatrix(float[] m)
		{
			unsafe {
				fixed (float* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixf != null, "pglMultMatrixf not implemented");
					Delegates.pglMultMatrixf(p_m);
					LogCommand("glMultMatrixf", null, m					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix with the specified matrix
		/// </summary>
		/// <param name="m">
		/// Points to 16 consecutive values that are used as the elements of a 4×4 column-major matrix.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.MultMatrix is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void MultMatrix(double[] m)
		{
			unsafe {
				fixed (double* p_m = m)
				{
					Debug.Assert(Delegates.pglMultMatrixd != null, "pglMultMatrixd not implemented");
					Delegates.pglMultMatrixd(p_m);
					LogCommand("glMultMatrixd", null, m					);
				}
			}
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix with an orthographic matrix
		/// </summary>
		/// <param name="left">
		/// Specify the coordinates for the left and right vertical clipping planes.
		/// </param>
		/// <param name="right">
		/// Specify the coordinates for the left and right vertical clipping planes.
		/// </param>
		/// <param name="bottom">
		/// Specify the coordinates for the bottom and top horizontal clipping planes.
		/// </param>
		/// <param name="top">
		/// Specify the coordinates for the bottom and top horizontal clipping planes.
		/// </param>
		/// <param name="zNear">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <param name="zFar">
		/// A <see cref="T:double"/>.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_VALUE is generated if <paramref name="left"/> = <paramref name="right"/>, or <paramref name="bottom"/> = 
		/// <paramref name="top"/>, or <paramref name="near"/> = <paramref name="far"/>.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Ortho is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Frustum"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Ortho(double left, double right, double bottom, double top, double zNear, double zFar)
		{
			Debug.Assert(Delegates.pglOrtho != null, "pglOrtho not implemented");
			Delegates.pglOrtho(left, right, bottom, top, zNear, zFar);
			LogCommand("glOrtho", null, left, right, bottom, top, zNear, zFar			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the current matrix stack
		/// </summary>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushMatrix is called while the current matrix stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopMatrix is called while the current matrix stack contains only a single matrix.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PushMatrix or Gl\.PopMatrix is executed between the execution of Gl\.Begin and 
		/// the corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Frustum"/>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.Ortho"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Scale"/>
		/// <seealso cref="Gl.Translate"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PopMatrix()
		{
			Debug.Assert(Delegates.pglPopMatrix != null, "pglPopMatrix not implemented");
			Delegates.pglPopMatrix();
			LogCommand("glPopMatrix", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// push and pop the current matrix stack
		/// </summary>
		/// <exception cref="KhronosException">
		/// Gl.STACK_OVERFLOW is generated if Gl.PushMatrix is called while the current matrix stack is full.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.STACK_UNDERFLOW is generated if Gl\.PopMatrix is called while the current matrix stack contains only a single matrix.
		/// </exception>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.PushMatrix or Gl\.PopMatrix is executed between the execution of Gl\.Begin and 
		/// the corresponding execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.Frustum"/>
		/// <seealso cref="Gl.LoadIdentity"/>
		/// <seealso cref="Gl.LoadMatrix"/>
		/// <seealso cref="Gl.LoadTransposeMatrix"/>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.MultTransposeMatrix"/>
		/// <seealso cref="Gl.Ortho"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Scale"/>
		/// <seealso cref="Gl.Translate"/>
		/// <seealso cref="Gl.Viewport"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void PushMatrix()
		{
			Debug.Assert(Delegates.pglPushMatrix != null, "pglPushMatrix not implemented");
			Delegates.pglPushMatrix();
			LogCommand("glPushMatrix", null			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix by a rotation matrix
		/// </summary>
		/// <param name="angle">
		/// Specifies the angle of rotation, in degrees.
		/// </param>
		/// <param name="x">
		/// Specify the x, y, and z coordinates of a vector, respectively.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, and z coordinates of a vector, respectively.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, and z coordinates of a vector, respectively.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rotate is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Scale"/>
		/// <seealso cref="Gl.Translate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rotate(double angle, double x, double y, double z)
		{
			Debug.Assert(Delegates.pglRotated != null, "pglRotated not implemented");
			Delegates.pglRotated(angle, x, y, z);
			LogCommand("glRotated", null, angle, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix by a rotation matrix
		/// </summary>
		/// <param name="angle">
		/// Specifies the angle of rotation, in degrees.
		/// </param>
		/// <param name="x">
		/// Specify the x, y, and z coordinates of a vector, respectively.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, and z coordinates of a vector, respectively.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, and z coordinates of a vector, respectively.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Rotate is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Scale"/>
		/// <seealso cref="Gl.Translate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Rotate(float angle, float x, float y, float z)
		{
			Debug.Assert(Delegates.pglRotatef != null, "pglRotatef not implemented");
			Delegates.pglRotatef(angle, x, y, z);
			LogCommand("glRotatef", null, angle, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix by a general scaling matrix
		/// </summary>
		/// <param name="x">
		/// Specify scale factors along the x, y, and z axes, respectively.
		/// </param>
		/// <param name="y">
		/// Specify scale factors along the x, y, and z axes, respectively.
		/// </param>
		/// <param name="z">
		/// Specify scale factors along the x, y, and z axes, respectively.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Scale is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Translate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Scale(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglScaled != null, "pglScaled not implemented");
			Delegates.pglScaled(x, y, z);
			LogCommand("glScaled", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix by a general scaling matrix
		/// </summary>
		/// <param name="x">
		/// Specify scale factors along the x, y, and z axes, respectively.
		/// </param>
		/// <param name="y">
		/// Specify scale factors along the x, y, and z axes, respectively.
		/// </param>
		/// <param name="z">
		/// Specify scale factors along the x, y, and z axes, respectively.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Scale is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Translate"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Scale(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglScalef != null, "pglScalef not implemented");
			Delegates.pglScalef(x, y, z);
			LogCommand("glScalef", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix by a translation matrix
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, and z coordinates of a translation vector.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, and z coordinates of a translation vector.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, and z coordinates of a translation vector.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Translate is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Scale"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Translate(double x, double y, double z)
		{
			Debug.Assert(Delegates.pglTranslated != null, "pglTranslated not implemented");
			Delegates.pglTranslated(x, y, z);
			LogCommand("glTranslated", null, x, y, z			);
			DebugCheckErrors(null);
		}

		/// <summary>
		/// multiply the current matrix by a translation matrix
		/// </summary>
		/// <param name="x">
		/// Specify the x, y, and z coordinates of a translation vector.
		/// </param>
		/// <param name="y">
		/// Specify the x, y, and z coordinates of a translation vector.
		/// </param>
		/// <param name="z">
		/// Specify the x, y, and z coordinates of a translation vector.
		/// </param>
		/// <exception cref="KhronosException">
		/// Gl.INVALID_OPERATION is generated if Gl.Translate is executed between the execution of Gl\.Begin and the corresponding 
		/// execution of Gl\.End.
		/// </exception>
		/// <seealso cref="Gl.MatrixMode"/>
		/// <seealso cref="Gl.MultMatrix"/>
		/// <seealso cref="Gl.PushMatrix"/>
		/// <seealso cref="Gl.Rotate"/>
		/// <seealso cref="Gl.Scale"/>
		[RequiredByFeature("GL_VERSION_1_0")]
		[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
		[RemovedByFeature("GL_VERSION_3_2")]
		public static void Translate(float x, float y, float z)
		{
			Debug.Assert(Delegates.pglTranslatef != null, "pglTranslatef not implemented");
			Delegates.pglTranslatef(x, y, z);
			LogCommand("glTranslatef", null, x, y, z			);
			DebugCheckErrors(null);
		}

		internal unsafe static partial class UnsafeNativeMethods
		{
			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCullFace", ExactSpelling = true)]
			internal extern static void glCullFace(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
			internal extern static void glFrontFace(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glHint", ExactSpelling = true)]
			internal extern static void glHint(Int32 target, Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
			internal extern static void glLineWidth(float width);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPointSize", ExactSpelling = true)]
			internal extern static void glPointSize(float size);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPolygonMode", ExactSpelling = true)]
			internal extern static void glPolygonMode(Int32 face, Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glScissor", ExactSpelling = true)]
			internal extern static void glScissor(Int32 x, Int32 y, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
			internal extern static void glTexParameterf(Int32 target, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glTexParameterfv(Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
			internal extern static void glTexParameteri(Int32 target, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glTexParameteriv(Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexImage1D", ExactSpelling = true)]
			internal extern static unsafe void glTexImage1D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
			internal extern static unsafe void glTexImage2D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawBuffer", ExactSpelling = true)]
			internal extern static void glDrawBuffer(Int32 buf);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClear", ExactSpelling = true)]
			internal extern static void glClear(UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearColor", ExactSpelling = true)]
			internal extern static void glClearColor(float red, float green, float blue, float alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
			internal extern static void glClearStencil(Int32 s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearDepth", ExactSpelling = true)]
			internal extern static void glClearDepth(double depth);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
			internal extern static void glStencilMask(UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorMask", ExactSpelling = true)]
			internal extern static void glColorMask(bool red, bool green, bool blue, bool alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
			internal extern static void glDepthMask(bool flag);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDisable", ExactSpelling = true)]
			internal extern static void glDisable(Int32 cap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEnable", ExactSpelling = true)]
			internal extern static void glEnable(Int32 cap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFinish", ExactSpelling = true)]
			internal extern static void glFinish();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFlush", ExactSpelling = true)]
			internal extern static void glFlush();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
			internal extern static void glBlendFunc(Int32 sfactor, Int32 dfactor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
			internal extern static void glLogicOp(Int32 opcode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
			internal extern static void glStencilFunc(Int32 func, Int32 @ref, UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
			internal extern static void glStencilOp(Int32 fail, Int32 zfail, Int32 zpass);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
			internal extern static void glDepthFunc(Int32 func);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelStoref", ExactSpelling = true)]
			internal extern static void glPixelStoref(Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
			internal extern static void glPixelStorei(Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReadBuffer", ExactSpelling = true)]
			internal extern static void glReadBuffer(Int32 src);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
			internal extern static unsafe void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
			internal extern static unsafe void glGetBooleanv(Int32 pname, bool* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetDoublev", ExactSpelling = true)]
			internal extern static unsafe void glGetDoublev(Int32 pname, double* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetError", ExactSpelling = true)]
			internal extern static Int32 glGetError();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
			internal extern static unsafe void glGetFloatv(Int32 pname, float* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
			internal extern static unsafe void glGetIntegerv(Int32 pname, Int32* data);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetString", ExactSpelling = true)]
			internal extern static IntPtr glGetString(Int32 name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexImage", ExactSpelling = true)]
			internal extern static unsafe void glGetTexImage(Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameterfv(Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexParameteriv(Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexLevelParameterfv(Int32 target, Int32 level, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexLevelParameteriv(Int32 target, Int32 level, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsEnabled(Int32 cap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDepthRange", ExactSpelling = true)]
			internal extern static void glDepthRange(double near, double far);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glViewport", ExactSpelling = true)]
			internal extern static void glViewport(Int32 x, Int32 y, Int32 width, Int32 height);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNewList", ExactSpelling = true)]
			internal extern static void glNewList(UInt32 list, Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEndList", ExactSpelling = true)]
			internal extern static void glEndList();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCallList", ExactSpelling = true)]
			internal extern static void glCallList(UInt32 list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCallLists", ExactSpelling = true)]
			internal extern static unsafe void glCallLists(Int32 n, Int32 type, IntPtr lists);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDeleteLists", ExactSpelling = true)]
			internal extern static void glDeleteLists(UInt32 list, Int32 range);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGenLists", ExactSpelling = true)]
			internal extern static UInt32 glGenLists(Int32 range);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glListBase", ExactSpelling = true)]
			internal extern static void glListBase(UInt32 @base);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBegin", ExactSpelling = true)]
			internal extern static void glBegin(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glBitmap", ExactSpelling = true)]
			internal extern static unsafe void glBitmap(Int32 width, Int32 height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3b", ExactSpelling = true)]
			internal extern static void glColor3b(sbyte red, sbyte green, sbyte blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3bv", ExactSpelling = true)]
			internal extern static unsafe void glColor3bv(sbyte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3d", ExactSpelling = true)]
			internal extern static void glColor3d(double red, double green, double blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3dv", ExactSpelling = true)]
			internal extern static unsafe void glColor3dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3f", ExactSpelling = true)]
			internal extern static void glColor3f(float red, float green, float blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3fv", ExactSpelling = true)]
			internal extern static unsafe void glColor3fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3i", ExactSpelling = true)]
			internal extern static void glColor3i(Int32 red, Int32 green, Int32 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3iv", ExactSpelling = true)]
			internal extern static unsafe void glColor3iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3s", ExactSpelling = true)]
			internal extern static void glColor3s(Int16 red, Int16 green, Int16 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3sv", ExactSpelling = true)]
			internal extern static unsafe void glColor3sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3ub", ExactSpelling = true)]
			internal extern static void glColor3ub(byte red, byte green, byte blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3ubv", ExactSpelling = true)]
			internal extern static unsafe void glColor3ubv(byte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3ui", ExactSpelling = true)]
			internal extern static void glColor3ui(UInt32 red, UInt32 green, UInt32 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3uiv", ExactSpelling = true)]
			internal extern static unsafe void glColor3uiv(UInt32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3us", ExactSpelling = true)]
			internal extern static void glColor3us(UInt16 red, UInt16 green, UInt16 blue);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor3usv", ExactSpelling = true)]
			internal extern static unsafe void glColor3usv(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4b", ExactSpelling = true)]
			internal extern static void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4bv", ExactSpelling = true)]
			internal extern static unsafe void glColor4bv(sbyte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4d", ExactSpelling = true)]
			internal extern static void glColor4d(double red, double green, double blue, double alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4dv", ExactSpelling = true)]
			internal extern static unsafe void glColor4dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4f", ExactSpelling = true)]
			internal extern static void glColor4f(float red, float green, float blue, float alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4fv", ExactSpelling = true)]
			internal extern static unsafe void glColor4fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4i", ExactSpelling = true)]
			internal extern static void glColor4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4iv", ExactSpelling = true)]
			internal extern static unsafe void glColor4iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4s", ExactSpelling = true)]
			internal extern static void glColor4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4sv", ExactSpelling = true)]
			internal extern static unsafe void glColor4sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4ub", ExactSpelling = true)]
			internal extern static void glColor4ub(byte red, byte green, byte blue, byte alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4ubv", ExactSpelling = true)]
			internal extern static unsafe void glColor4ubv(byte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4ui", ExactSpelling = true)]
			internal extern static void glColor4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4uiv", ExactSpelling = true)]
			internal extern static unsafe void glColor4uiv(UInt32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4us", ExactSpelling = true)]
			internal extern static void glColor4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColor4usv", ExactSpelling = true)]
			internal extern static unsafe void glColor4usv(UInt16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEdgeFlag", ExactSpelling = true)]
			internal extern static void glEdgeFlag(bool flag);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEdgeFlagv", ExactSpelling = true)]
			internal extern static unsafe void glEdgeFlagv(bool* flag);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEnd", ExactSpelling = true)]
			internal extern static void glEnd();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexd", ExactSpelling = true)]
			internal extern static void glIndexd(double c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexdv", ExactSpelling = true)]
			internal extern static unsafe void glIndexdv(double* c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexf", ExactSpelling = true)]
			internal extern static void glIndexf(float c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexfv", ExactSpelling = true)]
			internal extern static unsafe void glIndexfv(float* c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexi", ExactSpelling = true)]
			internal extern static void glIndexi(Int32 c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexiv", ExactSpelling = true)]
			internal extern static unsafe void glIndexiv(Int32* c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexs", ExactSpelling = true)]
			internal extern static void glIndexs(Int16 c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexsv", ExactSpelling = true)]
			internal extern static unsafe void glIndexsv(Int16* c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3b", ExactSpelling = true)]
			internal extern static void glNormal3b(sbyte nx, sbyte ny, sbyte nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3bv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3bv(sbyte* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3d", ExactSpelling = true)]
			internal extern static void glNormal3d(double nx, double ny, double nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3dv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3f", ExactSpelling = true)]
			internal extern static void glNormal3f(float nx, float ny, float nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3fv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3i", ExactSpelling = true)]
			internal extern static void glNormal3i(Int32 nx, Int32 ny, Int32 nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3iv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3s", ExactSpelling = true)]
			internal extern static void glNormal3s(Int16 nx, Int16 ny, Int16 nz);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glNormal3sv", ExactSpelling = true)]
			internal extern static unsafe void glNormal3sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2d", ExactSpelling = true)]
			internal extern static void glRasterPos2d(double x, double y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2dv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2f", ExactSpelling = true)]
			internal extern static void glRasterPos2f(float x, float y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2fv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2i", ExactSpelling = true)]
			internal extern static void glRasterPos2i(Int32 x, Int32 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2iv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2s", ExactSpelling = true)]
			internal extern static void glRasterPos2s(Int16 x, Int16 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos2sv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos2sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3d", ExactSpelling = true)]
			internal extern static void glRasterPos3d(double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3dv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3f", ExactSpelling = true)]
			internal extern static void glRasterPos3f(float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3fv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3i", ExactSpelling = true)]
			internal extern static void glRasterPos3i(Int32 x, Int32 y, Int32 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3iv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3s", ExactSpelling = true)]
			internal extern static void glRasterPos3s(Int16 x, Int16 y, Int16 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos3sv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos3sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4d", ExactSpelling = true)]
			internal extern static void glRasterPos4d(double x, double y, double z, double w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4dv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4f", ExactSpelling = true)]
			internal extern static void glRasterPos4f(float x, float y, float z, float w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4fv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4i", ExactSpelling = true)]
			internal extern static void glRasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4iv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4s", ExactSpelling = true)]
			internal extern static void glRasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRasterPos4sv", ExactSpelling = true)]
			internal extern static unsafe void glRasterPos4sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRectd", ExactSpelling = true)]
			internal extern static void glRectd(double x1, double y1, double x2, double y2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRectdv", ExactSpelling = true)]
			internal extern static unsafe void glRectdv(double* v1, double* v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRectf", ExactSpelling = true)]
			internal extern static void glRectf(float x1, float y1, float x2, float y2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRectfv", ExactSpelling = true)]
			internal extern static unsafe void glRectfv(float* v1, float* v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRecti", ExactSpelling = true)]
			internal extern static void glRecti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRectiv", ExactSpelling = true)]
			internal extern static unsafe void glRectiv(Int32* v1, Int32* v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRects", ExactSpelling = true)]
			internal extern static void glRects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRectsv", ExactSpelling = true)]
			internal extern static unsafe void glRectsv(Int16* v1, Int16* v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1d", ExactSpelling = true)]
			internal extern static void glTexCoord1d(double s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1dv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1f", ExactSpelling = true)]
			internal extern static void glTexCoord1f(float s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1fv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1i", ExactSpelling = true)]
			internal extern static void glTexCoord1i(Int32 s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1iv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1s", ExactSpelling = true)]
			internal extern static void glTexCoord1s(Int16 s);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord1sv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord1sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2d", ExactSpelling = true)]
			internal extern static void glTexCoord2d(double s, double t);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2dv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2f", ExactSpelling = true)]
			internal extern static void glTexCoord2f(float s, float t);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2fv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2i", ExactSpelling = true)]
			internal extern static void glTexCoord2i(Int32 s, Int32 t);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2iv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2s", ExactSpelling = true)]
			internal extern static void glTexCoord2s(Int16 s, Int16 t);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord2sv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord2sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3d", ExactSpelling = true)]
			internal extern static void glTexCoord3d(double s, double t, double r);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3dv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3f", ExactSpelling = true)]
			internal extern static void glTexCoord3f(float s, float t, float r);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3fv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3i", ExactSpelling = true)]
			internal extern static void glTexCoord3i(Int32 s, Int32 t, Int32 r);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3iv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3s", ExactSpelling = true)]
			internal extern static void glTexCoord3s(Int16 s, Int16 t, Int16 r);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord3sv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord3sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4d", ExactSpelling = true)]
			internal extern static void glTexCoord4d(double s, double t, double r, double q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4dv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4f", ExactSpelling = true)]
			internal extern static void glTexCoord4f(float s, float t, float r, float q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4fv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4i", ExactSpelling = true)]
			internal extern static void glTexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4iv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4s", ExactSpelling = true)]
			internal extern static void glTexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexCoord4sv", ExactSpelling = true)]
			internal extern static unsafe void glTexCoord4sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2d", ExactSpelling = true)]
			internal extern static void glVertex2d(double x, double y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2dv", ExactSpelling = true)]
			internal extern static unsafe void glVertex2dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2f", ExactSpelling = true)]
			internal extern static void glVertex2f(float x, float y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2fv", ExactSpelling = true)]
			internal extern static unsafe void glVertex2fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2i", ExactSpelling = true)]
			internal extern static void glVertex2i(Int32 x, Int32 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2iv", ExactSpelling = true)]
			internal extern static unsafe void glVertex2iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2s", ExactSpelling = true)]
			internal extern static void glVertex2s(Int16 x, Int16 y);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex2sv", ExactSpelling = true)]
			internal extern static unsafe void glVertex2sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3d", ExactSpelling = true)]
			internal extern static void glVertex3d(double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3dv", ExactSpelling = true)]
			internal extern static unsafe void glVertex3dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3f", ExactSpelling = true)]
			internal extern static void glVertex3f(float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3fv", ExactSpelling = true)]
			internal extern static unsafe void glVertex3fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3i", ExactSpelling = true)]
			internal extern static void glVertex3i(Int32 x, Int32 y, Int32 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3iv", ExactSpelling = true)]
			internal extern static unsafe void glVertex3iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3s", ExactSpelling = true)]
			internal extern static void glVertex3s(Int16 x, Int16 y, Int16 z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex3sv", ExactSpelling = true)]
			internal extern static unsafe void glVertex3sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4d", ExactSpelling = true)]
			internal extern static void glVertex4d(double x, double y, double z, double w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4dv", ExactSpelling = true)]
			internal extern static unsafe void glVertex4dv(double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4f", ExactSpelling = true)]
			internal extern static void glVertex4f(float x, float y, float z, float w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4fv", ExactSpelling = true)]
			internal extern static unsafe void glVertex4fv(float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4i", ExactSpelling = true)]
			internal extern static void glVertex4i(Int32 x, Int32 y, Int32 z, Int32 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4iv", ExactSpelling = true)]
			internal extern static unsafe void glVertex4iv(Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4s", ExactSpelling = true)]
			internal extern static void glVertex4s(Int16 x, Int16 y, Int16 z, Int16 w);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glVertex4sv", ExactSpelling = true)]
			internal extern static unsafe void glVertex4sv(Int16* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClipPlane", ExactSpelling = true)]
			internal extern static unsafe void glClipPlane(Int32 plane, double* equation);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glColorMaterial", ExactSpelling = true)]
			internal extern static void glColorMaterial(Int32 face, Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogf", ExactSpelling = true)]
			internal extern static void glFogf(Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogfv", ExactSpelling = true)]
			internal extern static unsafe void glFogfv(Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogi", ExactSpelling = true)]
			internal extern static void glFogi(Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFogiv", ExactSpelling = true)]
			internal extern static unsafe void glFogiv(Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightf", ExactSpelling = true)]
			internal extern static void glLightf(Int32 light, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightfv", ExactSpelling = true)]
			internal extern static unsafe void glLightfv(Int32 light, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLighti", ExactSpelling = true)]
			internal extern static void glLighti(Int32 light, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightiv", ExactSpelling = true)]
			internal extern static unsafe void glLightiv(Int32 light, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightModelf", ExactSpelling = true)]
			internal extern static void glLightModelf(Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightModelfv", ExactSpelling = true)]
			internal extern static unsafe void glLightModelfv(Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightModeli", ExactSpelling = true)]
			internal extern static void glLightModeli(Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLightModeliv", ExactSpelling = true)]
			internal extern static unsafe void glLightModeliv(Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLineStipple", ExactSpelling = true)]
			internal extern static void glLineStipple(Int32 factor, UInt16 pattern);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMaterialf", ExactSpelling = true)]
			internal extern static void glMaterialf(Int32 face, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMaterialfv", ExactSpelling = true)]
			internal extern static unsafe void glMaterialfv(Int32 face, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMateriali", ExactSpelling = true)]
			internal extern static void glMateriali(Int32 face, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMaterialiv", ExactSpelling = true)]
			internal extern static unsafe void glMaterialiv(Int32 face, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPolygonStipple", ExactSpelling = true)]
			internal extern static unsafe void glPolygonStipple(byte* mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glShadeModel", ExactSpelling = true)]
			internal extern static void glShadeModel(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexEnvf", ExactSpelling = true)]
			internal extern static void glTexEnvf(Int32 target, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexEnvfv", ExactSpelling = true)]
			internal extern static unsafe void glTexEnvfv(Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexEnvi", ExactSpelling = true)]
			internal extern static void glTexEnvi(Int32 target, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexEnviv", ExactSpelling = true)]
			internal extern static unsafe void glTexEnviv(Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGend", ExactSpelling = true)]
			internal extern static void glTexGend(Int32 coord, Int32 pname, double param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGendv", ExactSpelling = true)]
			internal extern static unsafe void glTexGendv(Int32 coord, Int32 pname, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGenf", ExactSpelling = true)]
			internal extern static void glTexGenf(Int32 coord, Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGenfv", ExactSpelling = true)]
			internal extern static unsafe void glTexGenfv(Int32 coord, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGeni", ExactSpelling = true)]
			internal extern static void glTexGeni(Int32 coord, Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTexGeniv", ExactSpelling = true)]
			internal extern static unsafe void glTexGeniv(Int32 coord, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFeedbackBuffer", ExactSpelling = true)]
			internal extern static unsafe void glFeedbackBuffer(Int32 size, Int32 type, float* buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glSelectBuffer", ExactSpelling = true)]
			internal extern static unsafe void glSelectBuffer(Int32 size, UInt32* buffer);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRenderMode", ExactSpelling = true)]
			internal extern static Int32 glRenderMode(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glInitNames", ExactSpelling = true)]
			internal extern static void glInitNames();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLoadName", ExactSpelling = true)]
			internal extern static void glLoadName(UInt32 name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPassThrough", ExactSpelling = true)]
			internal extern static void glPassThrough(float token);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPopName", ExactSpelling = true)]
			internal extern static void glPopName();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPushName", ExactSpelling = true)]
			internal extern static void glPushName(UInt32 name);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearAccum", ExactSpelling = true)]
			internal extern static void glClearAccum(float red, float green, float blue, float alpha);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glClearIndex", ExactSpelling = true)]
			internal extern static void glClearIndex(float c);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIndexMask", ExactSpelling = true)]
			internal extern static void glIndexMask(UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAccum", ExactSpelling = true)]
			internal extern static void glAccum(Int32 op, float value);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPopAttrib", ExactSpelling = true)]
			internal extern static void glPopAttrib();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPushAttrib", ExactSpelling = true)]
			internal extern static void glPushAttrib(UInt32 mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMap1d", ExactSpelling = true)]
			internal extern static unsafe void glMap1d(Int32 target, double u1, double u2, Int32 stride, Int32 order, double* points);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMap1f", ExactSpelling = true)]
			internal extern static unsafe void glMap1f(Int32 target, float u1, float u2, Int32 stride, Int32 order, float* points);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMap2d", ExactSpelling = true)]
			internal extern static unsafe void glMap2d(Int32 target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double* points);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMap2f", ExactSpelling = true)]
			internal extern static unsafe void glMap2f(Int32 target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float* points);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapGrid1d", ExactSpelling = true)]
			internal extern static void glMapGrid1d(Int32 un, double u1, double u2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapGrid1f", ExactSpelling = true)]
			internal extern static void glMapGrid1f(Int32 un, float u1, float u2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapGrid2d", ExactSpelling = true)]
			internal extern static void glMapGrid2d(Int32 un, double u1, double u2, Int32 vn, double v1, double v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMapGrid2f", ExactSpelling = true)]
			internal extern static void glMapGrid2f(Int32 un, float u1, float u2, Int32 vn, float v1, float v2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord1d", ExactSpelling = true)]
			internal extern static void glEvalCoord1d(double u);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord1dv", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord1dv(double* u);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord1f", ExactSpelling = true)]
			internal extern static void glEvalCoord1f(float u);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord1fv", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord1fv(float* u);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord2d", ExactSpelling = true)]
			internal extern static void glEvalCoord2d(double u, double v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord2dv", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord2dv(double* u);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord2f", ExactSpelling = true)]
			internal extern static void glEvalCoord2f(float u, float v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalCoord2fv", ExactSpelling = true)]
			internal extern static unsafe void glEvalCoord2fv(float* u);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalMesh1", ExactSpelling = true)]
			internal extern static void glEvalMesh1(Int32 mode, Int32 i1, Int32 i2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalPoint1", ExactSpelling = true)]
			internal extern static void glEvalPoint1(Int32 i);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalMesh2", ExactSpelling = true)]
			internal extern static void glEvalMesh2(Int32 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glEvalPoint2", ExactSpelling = true)]
			internal extern static void glEvalPoint2(Int32 i, Int32 j);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glAlphaFunc", ExactSpelling = true)]
			internal extern static void glAlphaFunc(Int32 func, float @ref);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelZoom", ExactSpelling = true)]
			internal extern static void glPixelZoom(float xfactor, float yfactor);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelTransferf", ExactSpelling = true)]
			internal extern static void glPixelTransferf(Int32 pname, float param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelTransferi", ExactSpelling = true)]
			internal extern static void glPixelTransferi(Int32 pname, Int32 param);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelMapfv", ExactSpelling = true)]
			internal extern static unsafe void glPixelMapfv(Int32 map, Int32 mapsize, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelMapuiv", ExactSpelling = true)]
			internal extern static unsafe void glPixelMapuiv(Int32 map, Int32 mapsize, UInt32* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPixelMapusv", ExactSpelling = true)]
			internal extern static unsafe void glPixelMapusv(Int32 map, Int32 mapsize, UInt16* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glCopyPixels", ExactSpelling = true)]
			internal extern static void glCopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 type);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glDrawPixels", ExactSpelling = true)]
			internal extern static unsafe void glDrawPixels(Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetClipPlane", ExactSpelling = true)]
			internal extern static unsafe void glGetClipPlane(Int32 plane, double* equation);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetLightfv", ExactSpelling = true)]
			internal extern static unsafe void glGetLightfv(Int32 light, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetLightiv", ExactSpelling = true)]
			internal extern static unsafe void glGetLightiv(Int32 light, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMapdv", ExactSpelling = true)]
			internal extern static unsafe void glGetMapdv(Int32 target, Int32 query, double* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMapfv", ExactSpelling = true)]
			internal extern static unsafe void glGetMapfv(Int32 target, Int32 query, float* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMapiv", ExactSpelling = true)]
			internal extern static unsafe void glGetMapiv(Int32 target, Int32 query, Int32* v);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMaterialfv", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialfv(Int32 face, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetMaterialiv", ExactSpelling = true)]
			internal extern static unsafe void glGetMaterialiv(Int32 face, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPixelMapfv", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelMapfv(Int32 map, float* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPixelMapuiv", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelMapuiv(Int32 map, UInt32* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPixelMapusv", ExactSpelling = true)]
			internal extern static unsafe void glGetPixelMapusv(Int32 map, UInt16* values);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetPolygonStipple", ExactSpelling = true)]
			internal extern static unsafe void glGetPolygonStipple(byte* mask);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexEnvfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexEnvfv(Int32 target, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexEnviv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexEnviv(Int32 target, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexGendv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGendv(Int32 coord, Int32 pname, double* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexGenfv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGenfv(Int32 coord, Int32 pname, float* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glGetTexGeniv", ExactSpelling = true)]
			internal extern static unsafe void glGetTexGeniv(Int32 coord, Int32 pname, Int32* @params);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glIsList", ExactSpelling = true)]
			[return: MarshalAs(UnmanagedType.I1)]
			internal extern static bool glIsList(UInt32 list);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glFrustum", ExactSpelling = true)]
			internal extern static void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLoadIdentity", ExactSpelling = true)]
			internal extern static void glLoadIdentity();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLoadMatrixf", ExactSpelling = true)]
			internal extern static unsafe void glLoadMatrixf(float* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glLoadMatrixd", ExactSpelling = true)]
			internal extern static unsafe void glLoadMatrixd(double* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMatrixMode", ExactSpelling = true)]
			internal extern static void glMatrixMode(Int32 mode);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultMatrixf", ExactSpelling = true)]
			internal extern static unsafe void glMultMatrixf(float* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glMultMatrixd", ExactSpelling = true)]
			internal extern static unsafe void glMultMatrixd(double* m);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glOrtho", ExactSpelling = true)]
			internal extern static void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPopMatrix", ExactSpelling = true)]
			internal extern static void glPopMatrix();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glPushMatrix", ExactSpelling = true)]
			internal extern static void glPushMatrix();

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRotated", ExactSpelling = true)]
			internal extern static void glRotated(double angle, double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glRotatef", ExactSpelling = true)]
			internal extern static void glRotatef(float angle, float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glScaled", ExactSpelling = true)]
			internal extern static void glScaled(double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glScalef", ExactSpelling = true)]
			internal extern static void glScalef(float x, float y, float z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTranslated", ExactSpelling = true)]
			internal extern static void glTranslated(double x, double y, double z);

			[SuppressUnmanagedCodeSecurity()]
			[DllImport(Library, EntryPoint = "glTranslatef", ExactSpelling = true)]
			internal extern static void glTranslatef(float x, float y, float z);

		}

		internal unsafe static partial class Delegates
		{
			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCullFace(Int32 mode);

			[ThreadStatic]
			internal static glCullFace pglCullFace;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrontFace(Int32 mode);

			[ThreadStatic]
			internal static glFrontFace pglFrontFace;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glHint(Int32 target, Int32 mode);

			[ThreadStatic]
			internal static glHint pglHint;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLineWidth(float width);

			[ThreadStatic]
			internal static glLineWidth pglLineWidth;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPointSize(float size);

			[ThreadStatic]
			internal static glPointSize pglPointSize;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_NV_polygon_mode", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPolygonMode(Int32 face, Int32 mode);

			[AliasOf("glPolygonMode")]
			[AliasOf("glPolygonModeNV")]
			[ThreadStatic]
			internal static glPolygonMode pglPolygonMode;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glScissor(Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glScissor pglScissor;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexParameterf(Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glTexParameterf pglTexParameterf;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameterfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTexParameterfv pglTexParameterfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexParameteri(Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTexParameteri pglTexParameteri;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexParameteriv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTexParameteriv pglTexParameteriv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexImage1D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTexImage1D pglTexImage1D;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexImage2D(Int32 target, Int32 level, Int32 internalformat, Int32 width, Int32 height, Int32 border, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glTexImage2D pglTexImage2D;

			[RequiredByFeature("GL_VERSION_1_0")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDrawBuffer(Int32 buf);

			[ThreadStatic]
			internal static glDrawBuffer pglDrawBuffer;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClear(UInt32 mask);

			[ThreadStatic]
			internal static glClear pglClear;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearColor(float red, float green, float blue, float alpha);

			[ThreadStatic]
			internal static glClearColor pglClearColor;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearStencil(Int32 s);

			[ThreadStatic]
			internal static glClearStencil pglClearStencil;

			[RequiredByFeature("GL_VERSION_1_0")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearDepth(double depth);

			[ThreadStatic]
			internal static glClearDepth pglClearDepth;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilMask(UInt32 mask);

			[ThreadStatic]
			internal static glStencilMask pglStencilMask;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorMask(bool red, bool green, bool blue, bool alpha);

			[ThreadStatic]
			internal static glColorMask pglColorMask;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthMask(bool flag);

			[ThreadStatic]
			internal static glDepthMask pglDepthMask;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDisable(Int32 cap);

			[ThreadStatic]
			internal static glDisable pglDisable;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnable(Int32 cap);

			[ThreadStatic]
			internal static glEnable pglEnable;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFinish();

			[ThreadStatic]
			internal static glFinish pglFinish;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFlush();

			[ThreadStatic]
			internal static glFlush pglFlush;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBlendFunc(Int32 sfactor, Int32 dfactor);

			[ThreadStatic]
			internal static glBlendFunc pglBlendFunc;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLogicOp(Int32 opcode);

			[ThreadStatic]
			internal static glLogicOp pglLogicOp;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilFunc(Int32 func, Int32 @ref, UInt32 mask);

			[ThreadStatic]
			internal static glStencilFunc pglStencilFunc;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glStencilOp(Int32 fail, Int32 zfail, Int32 zpass);

			[ThreadStatic]
			internal static glStencilOp pglStencilOp;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthFunc(Int32 func);

			[ThreadStatic]
			internal static glDepthFunc pglDepthFunc;

			[RequiredByFeature("GL_VERSION_1_0")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelStoref(Int32 pname, float param);

			[ThreadStatic]
			internal static glPixelStoref pglPixelStoref;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelStorei(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glPixelStorei pglPixelStorei;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_ES_VERSION_3_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glReadBuffer(Int32 src);

			[ThreadStatic]
			internal static glReadBuffer pglReadBuffer;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glReadPixels pglReadPixels;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetBooleanv(Int32 pname, bool* data);

			[ThreadStatic]
			internal static glGetBooleanv pglGetBooleanv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetDoublev(Int32 pname, double* data);

			[ThreadStatic]
			internal static glGetDoublev pglGetDoublev;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glGetError();

			[ThreadStatic]
			internal static glGetError pglGetError;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetFloatv(Int32 pname, float* data);

			[ThreadStatic]
			internal static glGetFloatv pglGetFloatv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetIntegerv(Int32 pname, Int32* data);

			[ThreadStatic]
			internal static glGetIntegerv pglGetIntegerv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate IntPtr glGetString(Int32 name);

			[ThreadStatic]
			internal static glGetString pglGetString;

			[RequiredByFeature("GL_VERSION_1_0")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexImage(Int32 target, Int32 level, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glGetTexImage pglGetTexImage;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameterfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexParameterfv pglGetTexParameterfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexParameteriv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexParameteriv pglGetTexParameteriv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexLevelParameterfv(Int32 target, Int32 level, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexLevelParameterfv pglGetTexLevelParameterfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_ES_VERSION_3_1", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexLevelParameteriv(Int32 target, Int32 level, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexLevelParameteriv pglGetTexLevelParameteriv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsEnabled(Int32 cap);

			[ThreadStatic]
			internal static glIsEnabled pglIsEnabled;

			[RequiredByFeature("GL_VERSION_1_0")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDepthRange(double near, double far);

			[ThreadStatic]
			internal static glDepthRange pglDepthRange;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RequiredByFeature("GL_ES_VERSION_2_0", Api = "gles2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glViewport(Int32 x, Int32 y, Int32 width, Int32 height);

			[ThreadStatic]
			internal static glViewport pglViewport;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNewList(UInt32 list, Int32 mode);

			[ThreadStatic]
			internal static glNewList pglNewList;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEndList();

			[ThreadStatic]
			internal static glEndList pglEndList;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCallList(UInt32 list);

			[ThreadStatic]
			internal static glCallList pglCallList;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glCallLists(Int32 n, Int32 type, IntPtr lists);

			[ThreadStatic]
			internal static glCallLists pglCallLists;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glDeleteLists(UInt32 list, Int32 range);

			[ThreadStatic]
			internal static glDeleteLists pglDeleteLists;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate UInt32 glGenLists(Int32 range);

			[ThreadStatic]
			internal static glGenLists pglGenLists;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glListBase(UInt32 @base);

			[ThreadStatic]
			internal static glListBase pglListBase;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glBegin(Int32 mode);

			[ThreadStatic]
			internal static glBegin pglBegin;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glBitmap(Int32 width, Int32 height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

			[ThreadStatic]
			internal static glBitmap pglBitmap;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3b(sbyte red, sbyte green, sbyte blue);

			[ThreadStatic]
			internal static glColor3b pglColor3b;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3bv(sbyte* v);

			[ThreadStatic]
			internal static glColor3bv pglColor3bv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3d(double red, double green, double blue);

			[ThreadStatic]
			internal static glColor3d pglColor3d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3dv(double* v);

			[ThreadStatic]
			internal static glColor3dv pglColor3dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3f(float red, float green, float blue);

			[ThreadStatic]
			internal static glColor3f pglColor3f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3fv(float* v);

			[ThreadStatic]
			internal static glColor3fv pglColor3fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3i(Int32 red, Int32 green, Int32 blue);

			[ThreadStatic]
			internal static glColor3i pglColor3i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3iv(Int32* v);

			[ThreadStatic]
			internal static glColor3iv pglColor3iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3s(Int16 red, Int16 green, Int16 blue);

			[ThreadStatic]
			internal static glColor3s pglColor3s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3sv(Int16* v);

			[ThreadStatic]
			internal static glColor3sv pglColor3sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3ub(byte red, byte green, byte blue);

			[ThreadStatic]
			internal static glColor3ub pglColor3ub;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3ubv(byte* v);

			[ThreadStatic]
			internal static glColor3ubv pglColor3ubv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3ui(UInt32 red, UInt32 green, UInt32 blue);

			[ThreadStatic]
			internal static glColor3ui pglColor3ui;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3uiv(UInt32* v);

			[ThreadStatic]
			internal static glColor3uiv pglColor3uiv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor3us(UInt16 red, UInt16 green, UInt16 blue);

			[ThreadStatic]
			internal static glColor3us pglColor3us;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor3usv(UInt16* v);

			[ThreadStatic]
			internal static glColor3usv pglColor3usv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

			[ThreadStatic]
			internal static glColor4b pglColor4b;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4bv(sbyte* v);

			[ThreadStatic]
			internal static glColor4bv pglColor4bv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4d(double red, double green, double blue, double alpha);

			[ThreadStatic]
			internal static glColor4d pglColor4d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4dv(double* v);

			[ThreadStatic]
			internal static glColor4dv pglColor4dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4f(float red, float green, float blue, float alpha);

			[ThreadStatic]
			internal static glColor4f pglColor4f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4fv(float* v);

			[ThreadStatic]
			internal static glColor4fv pglColor4fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);

			[ThreadStatic]
			internal static glColor4i pglColor4i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4iv(Int32* v);

			[ThreadStatic]
			internal static glColor4iv pglColor4iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);

			[ThreadStatic]
			internal static glColor4s pglColor4s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4sv(Int16* v);

			[ThreadStatic]
			internal static glColor4sv pglColor4sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4ub(byte red, byte green, byte blue, byte alpha);

			[ThreadStatic]
			internal static glColor4ub pglColor4ub;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4ubv(byte* v);

			[ThreadStatic]
			internal static glColor4ubv pglColor4ubv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);

			[ThreadStatic]
			internal static glColor4ui pglColor4ui;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4uiv(UInt32* v);

			[ThreadStatic]
			internal static glColor4uiv pglColor4uiv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColor4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);

			[ThreadStatic]
			internal static glColor4us pglColor4us;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glColor4usv(UInt16* v);

			[ThreadStatic]
			internal static glColor4usv pglColor4usv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEdgeFlag(bool flag);

			[ThreadStatic]
			internal static glEdgeFlag pglEdgeFlag;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEdgeFlagv(bool* flag);

			[ThreadStatic]
			internal static glEdgeFlagv pglEdgeFlagv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEnd();

			[ThreadStatic]
			internal static glEnd pglEnd;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexd(double c);

			[ThreadStatic]
			internal static glIndexd pglIndexd;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexdv(double* c);

			[ThreadStatic]
			internal static glIndexdv pglIndexdv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexf(float c);

			[ThreadStatic]
			internal static glIndexf pglIndexf;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexfv(float* c);

			[ThreadStatic]
			internal static glIndexfv pglIndexfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexi(Int32 c);

			[ThreadStatic]
			internal static glIndexi pglIndexi;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexiv(Int32* c);

			[ThreadStatic]
			internal static glIndexiv pglIndexiv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexs(Int16 c);

			[ThreadStatic]
			internal static glIndexs pglIndexs;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glIndexsv(Int16* c);

			[ThreadStatic]
			internal static glIndexsv pglIndexsv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3b(sbyte nx, sbyte ny, sbyte nz);

			[ThreadStatic]
			internal static glNormal3b pglNormal3b;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3bv(sbyte* v);

			[ThreadStatic]
			internal static glNormal3bv pglNormal3bv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3d(double nx, double ny, double nz);

			[ThreadStatic]
			internal static glNormal3d pglNormal3d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3dv(double* v);

			[ThreadStatic]
			internal static glNormal3dv pglNormal3dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3f(float nx, float ny, float nz);

			[ThreadStatic]
			internal static glNormal3f pglNormal3f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3fv(float* v);

			[ThreadStatic]
			internal static glNormal3fv pglNormal3fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3i(Int32 nx, Int32 ny, Int32 nz);

			[ThreadStatic]
			internal static glNormal3i pglNormal3i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3iv(Int32* v);

			[ThreadStatic]
			internal static glNormal3iv pglNormal3iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glNormal3s(Int16 nx, Int16 ny, Int16 nz);

			[ThreadStatic]
			internal static glNormal3s pglNormal3s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glNormal3sv(Int16* v);

			[ThreadStatic]
			internal static glNormal3sv pglNormal3sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos2d(double x, double y);

			[ThreadStatic]
			internal static glRasterPos2d pglRasterPos2d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2dv(double* v);

			[ThreadStatic]
			internal static glRasterPos2dv pglRasterPos2dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos2f(float x, float y);

			[ThreadStatic]
			internal static glRasterPos2f pglRasterPos2f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2fv(float* v);

			[ThreadStatic]
			internal static glRasterPos2fv pglRasterPos2fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos2i(Int32 x, Int32 y);

			[ThreadStatic]
			internal static glRasterPos2i pglRasterPos2i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2iv(Int32* v);

			[ThreadStatic]
			internal static glRasterPos2iv pglRasterPos2iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos2s(Int16 x, Int16 y);

			[ThreadStatic]
			internal static glRasterPos2s pglRasterPos2s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos2sv(Int16* v);

			[ThreadStatic]
			internal static glRasterPos2sv pglRasterPos2sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos3d(double x, double y, double z);

			[ThreadStatic]
			internal static glRasterPos3d pglRasterPos3d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3dv(double* v);

			[ThreadStatic]
			internal static glRasterPos3dv pglRasterPos3dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos3f(float x, float y, float z);

			[ThreadStatic]
			internal static glRasterPos3f pglRasterPos3f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3fv(float* v);

			[ThreadStatic]
			internal static glRasterPos3fv pglRasterPos3fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos3i(Int32 x, Int32 y, Int32 z);

			[ThreadStatic]
			internal static glRasterPos3i pglRasterPos3i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3iv(Int32* v);

			[ThreadStatic]
			internal static glRasterPos3iv pglRasterPos3iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos3s(Int16 x, Int16 y, Int16 z);

			[ThreadStatic]
			internal static glRasterPos3s pglRasterPos3s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos3sv(Int16* v);

			[ThreadStatic]
			internal static glRasterPos3sv pglRasterPos3sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos4d(double x, double y, double z, double w);

			[ThreadStatic]
			internal static glRasterPos4d pglRasterPos4d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4dv(double* v);

			[ThreadStatic]
			internal static glRasterPos4dv pglRasterPos4dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos4f(float x, float y, float z, float w);

			[ThreadStatic]
			internal static glRasterPos4f pglRasterPos4f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4fv(float* v);

			[ThreadStatic]
			internal static glRasterPos4fv pglRasterPos4fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glRasterPos4i pglRasterPos4i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4iv(Int32* v);

			[ThreadStatic]
			internal static glRasterPos4iv pglRasterPos4iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);

			[ThreadStatic]
			internal static glRasterPos4s pglRasterPos4s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRasterPos4sv(Int16* v);

			[ThreadStatic]
			internal static glRasterPos4sv pglRasterPos4sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRectd(double x1, double y1, double x2, double y2);

			[ThreadStatic]
			internal static glRectd pglRectd;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectdv(double* v1, double* v2);

			[ThreadStatic]
			internal static glRectdv pglRectdv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRectf(float x1, float y1, float x2, float y2);

			[ThreadStatic]
			internal static glRectf pglRectf;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectfv(float* v1, float* v2);

			[ThreadStatic]
			internal static glRectfv pglRectfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRecti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);

			[ThreadStatic]
			internal static glRecti pglRecti;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectiv(Int32* v1, Int32* v2);

			[ThreadStatic]
			internal static glRectiv pglRectiv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);

			[ThreadStatic]
			internal static glRects pglRects;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glRectsv(Int16* v1, Int16* v2);

			[ThreadStatic]
			internal static glRectsv pglRectsv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1d(double s);

			[ThreadStatic]
			internal static glTexCoord1d pglTexCoord1d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1dv(double* v);

			[ThreadStatic]
			internal static glTexCoord1dv pglTexCoord1dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1f(float s);

			[ThreadStatic]
			internal static glTexCoord1f pglTexCoord1f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1fv(float* v);

			[ThreadStatic]
			internal static glTexCoord1fv pglTexCoord1fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1i(Int32 s);

			[ThreadStatic]
			internal static glTexCoord1i pglTexCoord1i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1iv(Int32* v);

			[ThreadStatic]
			internal static glTexCoord1iv pglTexCoord1iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord1s(Int16 s);

			[ThreadStatic]
			internal static glTexCoord1s pglTexCoord1s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord1sv(Int16* v);

			[ThreadStatic]
			internal static glTexCoord1sv pglTexCoord1sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2d(double s, double t);

			[ThreadStatic]
			internal static glTexCoord2d pglTexCoord2d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2dv(double* v);

			[ThreadStatic]
			internal static glTexCoord2dv pglTexCoord2dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2f(float s, float t);

			[ThreadStatic]
			internal static glTexCoord2f pglTexCoord2f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2fv(float* v);

			[ThreadStatic]
			internal static glTexCoord2fv pglTexCoord2fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2i(Int32 s, Int32 t);

			[ThreadStatic]
			internal static glTexCoord2i pglTexCoord2i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2iv(Int32* v);

			[ThreadStatic]
			internal static glTexCoord2iv pglTexCoord2iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord2s(Int16 s, Int16 t);

			[ThreadStatic]
			internal static glTexCoord2s pglTexCoord2s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord2sv(Int16* v);

			[ThreadStatic]
			internal static glTexCoord2sv pglTexCoord2sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3d(double s, double t, double r);

			[ThreadStatic]
			internal static glTexCoord3d pglTexCoord3d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3dv(double* v);

			[ThreadStatic]
			internal static glTexCoord3dv pglTexCoord3dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3f(float s, float t, float r);

			[ThreadStatic]
			internal static glTexCoord3f pglTexCoord3f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3fv(float* v);

			[ThreadStatic]
			internal static glTexCoord3fv pglTexCoord3fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3i(Int32 s, Int32 t, Int32 r);

			[ThreadStatic]
			internal static glTexCoord3i pglTexCoord3i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3iv(Int32* v);

			[ThreadStatic]
			internal static glTexCoord3iv pglTexCoord3iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord3s(Int16 s, Int16 t, Int16 r);

			[ThreadStatic]
			internal static glTexCoord3s pglTexCoord3s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord3sv(Int16* v);

			[ThreadStatic]
			internal static glTexCoord3sv pglTexCoord3sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4d(double s, double t, double r, double q);

			[ThreadStatic]
			internal static glTexCoord4d pglTexCoord4d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4dv(double* v);

			[ThreadStatic]
			internal static glTexCoord4dv pglTexCoord4dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4f(float s, float t, float r, float q);

			[ThreadStatic]
			internal static glTexCoord4f pglTexCoord4f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4fv(float* v);

			[ThreadStatic]
			internal static glTexCoord4fv pglTexCoord4fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);

			[ThreadStatic]
			internal static glTexCoord4i pglTexCoord4i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4iv(Int32* v);

			[ThreadStatic]
			internal static glTexCoord4iv pglTexCoord4iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);

			[ThreadStatic]
			internal static glTexCoord4s pglTexCoord4s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexCoord4sv(Int16* v);

			[ThreadStatic]
			internal static glTexCoord4sv pglTexCoord4sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2d(double x, double y);

			[ThreadStatic]
			internal static glVertex2d pglVertex2d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2dv(double* v);

			[ThreadStatic]
			internal static glVertex2dv pglVertex2dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2f(float x, float y);

			[ThreadStatic]
			internal static glVertex2f pglVertex2f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2fv(float* v);

			[ThreadStatic]
			internal static glVertex2fv pglVertex2fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2i(Int32 x, Int32 y);

			[ThreadStatic]
			internal static glVertex2i pglVertex2i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2iv(Int32* v);

			[ThreadStatic]
			internal static glVertex2iv pglVertex2iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex2s(Int16 x, Int16 y);

			[ThreadStatic]
			internal static glVertex2s pglVertex2s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex2sv(Int16* v);

			[ThreadStatic]
			internal static glVertex2sv pglVertex2sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3d(double x, double y, double z);

			[ThreadStatic]
			internal static glVertex3d pglVertex3d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3dv(double* v);

			[ThreadStatic]
			internal static glVertex3dv pglVertex3dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3f(float x, float y, float z);

			[ThreadStatic]
			internal static glVertex3f pglVertex3f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3fv(float* v);

			[ThreadStatic]
			internal static glVertex3fv pglVertex3fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3i(Int32 x, Int32 y, Int32 z);

			[ThreadStatic]
			internal static glVertex3i pglVertex3i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3iv(Int32* v);

			[ThreadStatic]
			internal static glVertex3iv pglVertex3iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex3s(Int16 x, Int16 y, Int16 z);

			[ThreadStatic]
			internal static glVertex3s pglVertex3s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex3sv(Int16* v);

			[ThreadStatic]
			internal static glVertex3sv pglVertex3sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4d(double x, double y, double z, double w);

			[ThreadStatic]
			internal static glVertex4d pglVertex4d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4dv(double* v);

			[ThreadStatic]
			internal static glVertex4dv pglVertex4dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4f(float x, float y, float z, float w);

			[ThreadStatic]
			internal static glVertex4f pglVertex4f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4fv(float* v);

			[ThreadStatic]
			internal static glVertex4fv pglVertex4fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4i(Int32 x, Int32 y, Int32 z, Int32 w);

			[ThreadStatic]
			internal static glVertex4i pglVertex4i;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4iv(Int32* v);

			[ThreadStatic]
			internal static glVertex4iv pglVertex4iv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glVertex4s(Int16 x, Int16 y, Int16 z, Int16 w);

			[ThreadStatic]
			internal static glVertex4s pglVertex4s;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glVertex4sv(Int16* v);

			[ThreadStatic]
			internal static glVertex4sv pglVertex4sv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glClipPlane(Int32 plane, double* equation);

			[ThreadStatic]
			internal static glClipPlane pglClipPlane;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glColorMaterial(Int32 face, Int32 mode);

			[ThreadStatic]
			internal static glColorMaterial pglColorMaterial;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogf(Int32 pname, float param);

			[ThreadStatic]
			internal static glFogf pglFogf;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogfv(Int32 pname, float* @params);

			[ThreadStatic]
			internal static glFogfv pglFogfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFogi(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glFogi pglFogi;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFogiv(Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glFogiv pglFogiv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLightf(Int32 light, Int32 pname, float param);

			[ThreadStatic]
			internal static glLightf pglLightf;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightfv(Int32 light, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glLightfv pglLightfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLighti(Int32 light, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glLighti pglLighti;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightiv(Int32 light, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glLightiv pglLightiv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLightModelf(Int32 pname, float param);

			[ThreadStatic]
			internal static glLightModelf pglLightModelf;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightModelfv(Int32 pname, float* @params);

			[ThreadStatic]
			internal static glLightModelfv pglLightModelfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLightModeli(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glLightModeli pglLightModeli;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLightModeliv(Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glLightModeliv pglLightModeliv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLineStipple(Int32 factor, UInt16 pattern);

			[ThreadStatic]
			internal static glLineStipple pglLineStipple;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMaterialf(Int32 face, Int32 pname, float param);

			[ThreadStatic]
			internal static glMaterialf pglMaterialf;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMaterialfv(Int32 face, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glMaterialfv pglMaterialfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMateriali(Int32 face, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glMateriali pglMateriali;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMaterialiv(Int32 face, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glMaterialiv pglMaterialiv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPolygonStipple(byte* mask);

			[ThreadStatic]
			internal static glPolygonStipple pglPolygonStipple;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glShadeModel(Int32 mode);

			[ThreadStatic]
			internal static glShadeModel pglShadeModel;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexEnvf(Int32 target, Int32 pname, float param);

			[ThreadStatic]
			internal static glTexEnvf pglTexEnvf;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexEnvfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTexEnvfv pglTexEnvfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexEnvi(Int32 target, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTexEnvi pglTexEnvi;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexEnviv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTexEnviv pglTexEnviv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexGend(Int32 coord, Int32 pname, double param);

			[ThreadStatic]
			internal static glTexGend pglTexGend;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGendv(Int32 coord, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glTexGendv pglTexGendv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexGenf(Int32 coord, Int32 pname, float param);

			[ThreadStatic]
			internal static glTexGenf pglTexGenf;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGenfv(Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glTexGenfv pglTexGenfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTexGeni(Int32 coord, Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glTexGeni pglTexGeni;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glTexGeniv(Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glTexGeniv pglTexGeniv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glFeedbackBuffer(Int32 size, Int32 type, float* buffer);

			[ThreadStatic]
			internal static glFeedbackBuffer pglFeedbackBuffer;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glSelectBuffer(Int32 size, UInt32* buffer);

			[ThreadStatic]
			internal static glSelectBuffer pglSelectBuffer;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate Int32 glRenderMode(Int32 mode);

			[ThreadStatic]
			internal static glRenderMode pglRenderMode;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glInitNames();

			[ThreadStatic]
			internal static glInitNames pglInitNames;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLoadName(UInt32 name);

			[ThreadStatic]
			internal static glLoadName pglLoadName;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPassThrough(float token);

			[ThreadStatic]
			internal static glPassThrough pglPassThrough;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopName();

			[ThreadStatic]
			internal static glPopName pglPopName;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushName(UInt32 name);

			[ThreadStatic]
			internal static glPushName pglPushName;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearAccum(float red, float green, float blue, float alpha);

			[ThreadStatic]
			internal static glClearAccum pglClearAccum;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glClearIndex(float c);

			[ThreadStatic]
			internal static glClearIndex pglClearIndex;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glIndexMask(UInt32 mask);

			[ThreadStatic]
			internal static glIndexMask pglIndexMask;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAccum(Int32 op, float value);

			[ThreadStatic]
			internal static glAccum pglAccum;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopAttrib();

			[ThreadStatic]
			internal static glPopAttrib pglPopAttrib;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushAttrib(UInt32 mask);

			[ThreadStatic]
			internal static glPushAttrib pglPushAttrib;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap1d(Int32 target, double u1, double u2, Int32 stride, Int32 order, double* points);

			[ThreadStatic]
			internal static glMap1d pglMap1d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap1f(Int32 target, float u1, float u2, Int32 stride, Int32 order, float* points);

			[ThreadStatic]
			internal static glMap1f pglMap1f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap2d(Int32 target, double u1, double u2, Int32 ustride, Int32 uorder, double v1, double v2, Int32 vstride, Int32 vorder, double* points);

			[ThreadStatic]
			internal static glMap2d pglMap2d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMap2f(Int32 target, float u1, float u2, Int32 ustride, Int32 uorder, float v1, float v2, Int32 vstride, Int32 vorder, float* points);

			[ThreadStatic]
			internal static glMap2f pglMap2f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMapGrid1d(Int32 un, double u1, double u2);

			[ThreadStatic]
			internal static glMapGrid1d pglMapGrid1d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMapGrid1f(Int32 un, float u1, float u2);

			[ThreadStatic]
			internal static glMapGrid1f pglMapGrid1f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMapGrid2d(Int32 un, double u1, double u2, Int32 vn, double v1, double v2);

			[ThreadStatic]
			internal static glMapGrid2d pglMapGrid2d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMapGrid2f(Int32 un, float u1, float u2, Int32 vn, float v1, float v2);

			[ThreadStatic]
			internal static glMapGrid2f pglMapGrid2f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalCoord1d(double u);

			[ThreadStatic]
			internal static glEvalCoord1d pglEvalCoord1d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord1dv(double* u);

			[ThreadStatic]
			internal static glEvalCoord1dv pglEvalCoord1dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalCoord1f(float u);

			[ThreadStatic]
			internal static glEvalCoord1f pglEvalCoord1f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord1fv(float* u);

			[ThreadStatic]
			internal static glEvalCoord1fv pglEvalCoord1fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalCoord2d(double u, double v);

			[ThreadStatic]
			internal static glEvalCoord2d pglEvalCoord2d;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord2dv(double* u);

			[ThreadStatic]
			internal static glEvalCoord2dv pglEvalCoord2dv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalCoord2f(float u, float v);

			[ThreadStatic]
			internal static glEvalCoord2f pglEvalCoord2f;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glEvalCoord2fv(float* u);

			[ThreadStatic]
			internal static glEvalCoord2fv pglEvalCoord2fv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalMesh1(Int32 mode, Int32 i1, Int32 i2);

			[ThreadStatic]
			internal static glEvalMesh1 pglEvalMesh1;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalPoint1(Int32 i);

			[ThreadStatic]
			internal static glEvalPoint1 pglEvalPoint1;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalMesh2(Int32 mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);

			[ThreadStatic]
			internal static glEvalMesh2 pglEvalMesh2;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glEvalPoint2(Int32 i, Int32 j);

			[ThreadStatic]
			internal static glEvalPoint2 pglEvalPoint2;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glAlphaFunc(Int32 func, float @ref);

			[ThreadStatic]
			internal static glAlphaFunc pglAlphaFunc;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelZoom(float xfactor, float yfactor);

			[ThreadStatic]
			internal static glPixelZoom pglPixelZoom;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransferf(Int32 pname, float param);

			[ThreadStatic]
			internal static glPixelTransferf pglPixelTransferf;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPixelTransferi(Int32 pname, Int32 param);

			[ThreadStatic]
			internal static glPixelTransferi pglPixelTransferi;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelMapfv(Int32 map, Int32 mapsize, float* values);

			[ThreadStatic]
			internal static glPixelMapfv pglPixelMapfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelMapuiv(Int32 map, Int32 mapsize, UInt32* values);

			[ThreadStatic]
			internal static glPixelMapuiv pglPixelMapuiv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glPixelMapusv(Int32 map, Int32 mapsize, UInt16* values);

			[ThreadStatic]
			internal static glPixelMapusv pglPixelMapusv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glCopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, Int32 type);

			[ThreadStatic]
			internal static glCopyPixels pglCopyPixels;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glDrawPixels(Int32 width, Int32 height, Int32 format, Int32 type, IntPtr pixels);

			[ThreadStatic]
			internal static glDrawPixels pglDrawPixels;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetClipPlane(Int32 plane, double* equation);

			[ThreadStatic]
			internal static glGetClipPlane pglGetClipPlane;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetLightfv(Int32 light, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetLightfv pglGetLightfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetLightiv(Int32 light, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetLightiv pglGetLightiv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapdv(Int32 target, Int32 query, double* v);

			[ThreadStatic]
			internal static glGetMapdv pglGetMapdv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapfv(Int32 target, Int32 query, float* v);

			[ThreadStatic]
			internal static glGetMapfv pglGetMapfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMapiv(Int32 target, Int32 query, Int32* v);

			[ThreadStatic]
			internal static glGetMapiv pglGetMapiv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMaterialfv(Int32 face, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetMaterialfv pglGetMaterialfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetMaterialiv(Int32 face, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetMaterialiv pglGetMaterialiv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelMapfv(Int32 map, float* values);

			[ThreadStatic]
			internal static glGetPixelMapfv pglGetPixelMapfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelMapuiv(Int32 map, UInt32* values);

			[ThreadStatic]
			internal static glGetPixelMapuiv pglGetPixelMapuiv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPixelMapusv(Int32 map, UInt16* values);

			[ThreadStatic]
			internal static glGetPixelMapusv pglGetPixelMapusv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetPolygonStipple(byte* mask);

			[ThreadStatic]
			internal static glGetPolygonStipple pglGetPolygonStipple;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexEnvfv(Int32 target, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexEnvfv pglGetTexEnvfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexEnviv(Int32 target, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexEnviv pglGetTexEnviv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexGendv(Int32 coord, Int32 pname, double* @params);

			[ThreadStatic]
			internal static glGetTexGendv pglGetTexGendv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexGenfv(Int32 coord, Int32 pname, float* @params);

			[ThreadStatic]
			internal static glGetTexGenfv pglGetTexGenfv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glGetTexGeniv(Int32 coord, Int32 pname, Int32* @params);

			[ThreadStatic]
			internal static glGetTexGeniv pglGetTexGeniv;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate bool glIsList(UInt32 list);

			[ThreadStatic]
			internal static glIsList pglIsList;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glFrustum(double left, double right, double bottom, double top, double zNear, double zFar);

			[ThreadStatic]
			internal static glFrustum pglFrustum;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glLoadIdentity();

			[ThreadStatic]
			internal static glLoadIdentity pglLoadIdentity;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadMatrixf(float* m);

			[ThreadStatic]
			internal static glLoadMatrixf pglLoadMatrixf;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glLoadMatrixd(double* m);

			[ThreadStatic]
			internal static glLoadMatrixd pglLoadMatrixd;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glMatrixMode(Int32 mode);

			[ThreadStatic]
			internal static glMatrixMode pglMatrixMode;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultMatrixf(float* m);

			[ThreadStatic]
			internal static glMultMatrixf pglMultMatrixf;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal unsafe delegate void glMultMatrixd(double* m);

			[ThreadStatic]
			internal static glMultMatrixd pglMultMatrixd;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glOrtho(double left, double right, double bottom, double top, double zNear, double zFar);

			[ThreadStatic]
			internal static glOrtho pglOrtho;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPopMatrix();

			[ThreadStatic]
			internal static glPopMatrix pglPopMatrix;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glPushMatrix();

			[ThreadStatic]
			internal static glPushMatrix pglPushMatrix;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRotated(double angle, double x, double y, double z);

			[ThreadStatic]
			internal static glRotated pglRotated;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glRotatef(float angle, float x, float y, float z);

			[ThreadStatic]
			internal static glRotatef pglRotatef;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glScaled(double x, double y, double z);

			[ThreadStatic]
			internal static glScaled pglScaled;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glScalef(float x, float y, float z);

			[ThreadStatic]
			internal static glScalef pglScalef;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTranslated(double x, double y, double z);

			[ThreadStatic]
			internal static glTranslated pglTranslated;

			[RequiredByFeature("GL_VERSION_1_0")]
			[RequiredByFeature("GL_VERSION_ES_CM_1_0", Api = "gles1")]
			[RemovedByFeature("GL_VERSION_3_2")]
			[SuppressUnmanagedCodeSecurity()]
			internal delegate void glTranslatef(float x, float y, float z);

			[ThreadStatic]
			internal static glTranslatef pglTranslatef;

		}
	}

}
