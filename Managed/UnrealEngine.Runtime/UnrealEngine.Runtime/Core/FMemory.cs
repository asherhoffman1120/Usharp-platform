﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime
{
    /// <summary>
    /// Memory functions (wrapper for FPlatformMemory)
    /// </summary>
    public static class FMemory
    {
        /// <summary>
        /// Default allocator alignment. If the default is specified, the allocator applies to engine rules.
        /// Blocks >= 16 bytes will be 16-byte-aligned, Blocks &lt; 16 will be 8-byte aligned. If the allocator does
        /// not support allocation alignment, the alignment will be ignored.
        /// </summary>
        public const uint DEFAULT_ALIGNMENT = 0;

        /// <summary>
        /// Minimum allocator alignment
        /// </summary>
        public const uint MIN_ALIGNMENT = 8;

        public static IntPtr Memmove(IntPtr dest, IntPtr src, int count)
        {
            return Native_FMemory.Memmove(dest, src, (ulong)count);
        }

        public static IntPtr Memmove(IntPtr dest, IntPtr src, uint count)
        {
            return Native_FMemory.Memmove(dest, src, count);
        }

        public static IntPtr Memmove(IntPtr dest, IntPtr src, ulong count)
        {
            return Native_FMemory.Memmove(dest, src, count);
        }

        public static int Memcmp(IntPtr dest, IntPtr src, int count)
        {
            return Native_FMemory.Memcmp(dest, src, (ulong)count);
        }

        public static int Memcmp(IntPtr dest, IntPtr src, uint count)
        {
            return Native_FMemory.Memcmp(dest, src, count);
        }

        public static int Memcmp(IntPtr dest, IntPtr src, ulong count)
        {
            return Native_FMemory.Memcmp(dest, src, count);
        }

        public static IntPtr Memset(IntPtr dest, byte value, int count)
        {
            return Native_FMemory.Memset(dest, value, (ulong)count);
        }

        public static IntPtr Memset(IntPtr dest, byte value, uint count)
        {
            return Native_FMemory.Memset(dest, value, count);
        }

        public static IntPtr Memset(IntPtr dest, byte value, ulong count)
        {
            return Native_FMemory.Memset(dest, value, count);
        }

        public static IntPtr Memzero(IntPtr dest, int count)
        {
            return Native_FMemory.Memzero(dest, (ulong)count);
        }

        public static IntPtr Memzero(IntPtr dest, uint count)
        {
            return Native_FMemory.Memzero(dest, count);
        }

        public static IntPtr Memzero(IntPtr dest, ulong count)
        {
            return Native_FMemory.Memzero(dest, count);
        }
        
        public static void Memzero<T>(ref T value) where T : struct
        {
            value = default(T);
        }

        public static IntPtr Memcpy(IntPtr dest, IntPtr src, int count)
        {
            return Native_FMemory.Memcpy(dest, src, (ulong)count);
        }

        public static IntPtr Memcpy(IntPtr dest, IntPtr src, uint count)
        {
            return Native_FMemory.Memcpy(dest, src, count);
        }

        public static IntPtr Memcpy(IntPtr dest, IntPtr src, ulong count)
        {
            return Native_FMemory.Memcpy(dest, src, count);
        }

        public static IntPtr BigBlockMemcpy(IntPtr dest, IntPtr src, int count)
        {
            return Native_FMemory.BigBlockMemcpy(dest, src, (ulong)count);
        }

        public static IntPtr BigBlockMemcpy(IntPtr dest, IntPtr src, uint count)
        {
            return Native_FMemory.BigBlockMemcpy(dest, src, count);
        }

        public static IntPtr BigBlockMemcpy(IntPtr dest, IntPtr src, ulong count)
        {
            return Native_FMemory.BigBlockMemcpy(dest, src, count);
        }

        public static IntPtr StreamingMemcpy(IntPtr dest, IntPtr src, int count)
        {
            return Native_FMemory.StreamingMemcpy(dest, src, (ulong)count);
        }

        public static IntPtr StreamingMemcpy(IntPtr dest, IntPtr src, uint count)
        {
            return Native_FMemory.StreamingMemcpy(dest, src, count);
        }

        public static IntPtr StreamingMemcpy(IntPtr dest, IntPtr src, ulong count)
        {
            return Native_FMemory.StreamingMemcpy(dest, src, count);
        }

        public static void Memswap(IntPtr ptr1, IntPtr ptr2, int size)
        {
            Native_FMemory.Memswap(ptr1, ptr2, (ulong)size);
        }

        public static void Memswap(IntPtr ptr1, IntPtr ptr2, uint size)
        {
            Native_FMemory.Memswap(ptr1, ptr2, size);
        }

        public static void Memswap(IntPtr ptr1, IntPtr ptr2, ulong size)
        {
            Native_FMemory.Memswap(ptr1, ptr2, size);
        }

        public static IntPtr SystemMalloc(int size)
        {
            return Native_FMemory.SystemMalloc((ulong)size);
        }

        public static IntPtr SystemMalloc(uint size)
        {
            return Native_FMemory.SystemMalloc(size);
        }

        public static IntPtr SystemMalloc(ulong size)
        {
            return Native_FMemory.SystemMalloc(size);
        }

        public static void SystemFree(IntPtr ptr)
        {
            Native_FMemory.SystemFree(ptr);
        }

        public static IntPtr Malloc(int count, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.Malloc((ulong)count, alignment);
        }

        public static IntPtr Malloc(uint count, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.Malloc(count, alignment);
        }

        public static IntPtr Malloc(ulong count, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.Malloc(count, alignment);
        }

        public static IntPtr Realloc(IntPtr original, int count, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.Realloc(original, (ulong)count, alignment);
        }

        public static IntPtr Realloc(IntPtr original, uint count, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.Realloc(original, count, alignment);
        }

        public static IntPtr Realloc(IntPtr original, ulong count, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.Realloc(original, count, alignment);
        }

        public static void Free(IntPtr original)
        {
            Native_FMemory.Free(original);
        }

        public static ulong GetAllocSize(IntPtr original)
        {
            return Native_FMemory.GetAllocSize(original);
        }

        /// <summary>
        /// For some allocators this will return the actual size that should be requested to eliminate
        /// internal fragmentation. The return value will always be >= Count. This can be used to grow
        /// and shrink containers to optimal sizes.
        /// This call is always fast and threadsafe with no locking.
        /// </summary>
        public static ulong QuantizeSize(int count, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.QuantizeSize((ulong)count, alignment);
        }

        public static ulong QuantizeSize(uint count, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.QuantizeSize(count, alignment);
        }

        public static ulong QuantizeSize(ulong count, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.QuantizeSize(count, alignment);
        }

        /// <summary>
        /// Releases as much memory as possible. Must be called from the main thread.
        /// </summary>
        public static void Trim()
        {
            Native_FMemory.Trim();
        }

        /// <summary>
        /// Set up TLS caches on the current thread. These are the threads that we can trim.
        /// </summary>
        public static void SetupTLSCachesOnCurrentThread()
        {
            Native_FMemory.SetupTLSCachesOnCurrentThread();
        }

        /// <summary>
        /// Clears the TLS caches on the current thread and disables any future caching.
        /// </summary>
        public static void ClearAndDisableTLSCachesOnCurrentThread()
        {
            Native_FMemory.ClearAndDisableTLSCachesOnCurrentThread();
        }

        /// <summary>
        /// Malloc for GPU mapped memory on UMA systems (XB1/PS4/etc)
        /// It is expected that the RHI on platforms that use these knows what to 
        /// do with the memory and avoids unnecessary copies into GPU resources, etc.
        /// </summary>
        public static IntPtr GPUMalloc(int count, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.GPUMalloc((ulong)count, alignment);
        }

        public static IntPtr GPUMalloc(uint count, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.GPUMalloc(count, alignment);
        }

        public static IntPtr GPUMalloc(ulong count, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.GPUMalloc(count, alignment);
        }

        public static IntPtr GPURealloc(IntPtr original, int size, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.GPURealloc(original, (ulong)size, alignment);
        }

        public static IntPtr GPURealloc(IntPtr original, uint size, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.GPURealloc(original, size, alignment);
        }

        public static IntPtr GPURealloc(IntPtr original, ulong size, uint alignment = DEFAULT_ALIGNMENT)
        {
            return Native_FMemory.GPURealloc(original, size, alignment);
        }

        public static IntPtr GPUFree(IntPtr original)
        {
            return Native_FMemory.GPUFree(original);
        }

        /// <summary>
        /// A helper function that will perform a series of random heap allocations to test
        /// the internal validity of the heap. Note, this function will "leak" memory, but another call
        /// will clean up previously allocated blocks before returning. This will help to A/B testing
        /// where you call it in a good state, do something to corrupt memory, then call this again
        /// and hopefully freeing some pointers will trigger a crash.
        /// </summary>
        public static void TestMemory()
        {
            Native_FMemory.TestMemory();
        }

        /// <summary>
        /// Called once main is started and we have -purgatorymallocproxy.
        /// This uses the purgatory malloc proxy to check if things are writing to stale pointers.
        /// </summary>
        public static void EnablePurgatoryTests()
        {
            Native_FMemory.EnablePurgatoryTests();
        }
    }
}
