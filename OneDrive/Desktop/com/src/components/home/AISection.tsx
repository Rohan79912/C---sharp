import React from "react";
import { Sparkles, Video, Image as ImageIcon, Zap } from "lucide-react";

const AISection = () => {
  return (
    <section id="ai-editing" className="py-24 bg-black overflow-hidden">
      <div className="max-w-7xl mx-auto px-6 grid grid-cols-1 lg:grid-cols-2 gap-16 items-center">
        <div>
          <div className="inline-flex items-center gap-2 px-3 py-1 rounded-full border border-zinc-800 bg-zinc-900/50 text-white text-xs font-medium mb-6">
            <Sparkles className="w-3 h-3" />
            <span>AI Powered Editing Pipeline</span>
          </div>
          <h2 className="text-4xl md:text-5xl font-bold text-white mb-8 leading-tight">
            Your memories, <br />
            <span className="text-gradient">Enhanced by AI.</span>
          </h2>
          <p className="text-zinc-400 text-lg mb-10 leading-relaxed">
            Our proprietary AI platform automatically handles color grading, noise reduction, 
            and cinematic cut generation. Get social-ready reels and stabilized footage delivered 
            faster than any traditional studio.
          </p>
          
          <div className="space-y-6">
            <div className="flex gap-4 p-4 rounded-xl hover:bg-zinc-900/50 transition-colors border border-transparent hover:border-zinc-800">
              <div className="flex-shrink-0 w-10 h-10 rounded-lg bg-white/10 flex items-center justify-center text-white">
                <Video className="w-5 h-5" />
              </div>
              <div>
                <h4 className="text-white font-semibold mb-1">Auto-Reel Generation</h4>
                <p className="text-zinc-500 text-sm">AI detects the best moments and compiles them into cinematic 60-second reels.</p>
              </div>
            </div>
            
            <div className="flex gap-4 p-4 rounded-xl hover:bg-zinc-900/50 transition-colors border border-transparent hover:border-zinc-800">
              <div className="flex-shrink-0 w-10 h-10 rounded-lg bg-white/10 flex items-center justify-center text-white">
                <Zap className="w-5 h-5" />
              </div>
              <div>
                <h4 className="text-white font-semibold mb-1">Smart Color Grading</h4>
                <p className="text-zinc-500 text-sm">Automatic exposure and color correction based on the event's vibe and lighting.</p>
              </div>
            </div>
          </div>
        </div>

        <div className="relative">
          <div className="absolute -inset-4 bg-white/5 blur-3xl rounded-full -z-10" />
          <div className="aspect-square rounded-3xl bg-zinc-900 border border-zinc-800 flex items-center justify-center p-8 overflow-hidden group">
             {/* Mock AI Interface */}
             <div className="w-full h-full rounded-2xl bg-black border border-zinc-800 p-6 flex flex-col gap-4">
                <div className="flex justify-between items-center pb-4 border-b border-zinc-800">
                   <div className="flex gap-2">
                      <div className="w-3 h-3 rounded-full bg-red-500/20 border border-red-500/50" />
                      <div className="w-3 h-3 rounded-full bg-yellow-500/20 border border-yellow-500/50" />
                      <div className="w-3 h-3 rounded-full bg-green-500/20 border border-green-500/50" />
                   </div>
                   <span className="text-[10px] text-zinc-600 font-mono tracking-widest uppercase">Processing Batch #4092</span>
                </div>
                <div className="flex-grow flex items-center justify-center relative">
                   <div className="w-full h-32 bg-zinc-900/50 rounded-lg border border-dashed border-zinc-700 flex flex-col items-center justify-center gap-2 group-hover:border-white/20 transition-all">
                      <ImageIcon className="w-8 h-8 text-zinc-600 group-hover:text-white transition-all" />
                      <span className="text-[10px] text-zinc-600">Analyzing Face Data...</span>
                   </div>
                   <div className="absolute inset-0 flex items-center justify-center pointer-events-none">
                      <div className="w-[1px] h-full bg-white/20 absolute animate-[scan_3s_infinite]" />
                   </div>
                </div>
                <div className="grid grid-cols-2 gap-4">
                   <div className="h-2 rounded bg-zinc-800 overflow-hidden">
                      <div className="h-full w-3/4 bg-white animate-pulse" />
                   </div>
                   <div className="h-2 rounded bg-zinc-800 overflow-hidden">
                      <div className="h-full w-1/2 bg-zinc-400" />
                   </div>
                </div>
             </div>
          </div>
        </div>
      </div>
    </section>
  );
};

export default AISection;
