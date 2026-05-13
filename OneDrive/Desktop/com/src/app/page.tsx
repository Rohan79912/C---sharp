import Hero from "@/components/home/Hero";
import Features from "@/components/home/Features";
import AISection from "@/components/home/AISection";

export default function Home() {
  return (
    <div className="bg-black min-h-screen">
      <Hero />
      <Features />
      <AISection />
      
      {/* Social Proof / Numbers Section */}
      <section className="py-24 border-t border-zinc-900">
        <div className="max-w-7xl mx-auto px-6 grid grid-cols-2 md:grid-cols-4 gap-12 text-center">
          <div>
            <div className="text-4xl font-bold text-white mb-2">5k+</div>
            <div className="text-sm text-zinc-500 uppercase tracking-widest">Photographers</div>
          </div>
          <div>
            <div className="text-4xl font-bold text-white mb-2">20k+</div>
            <div className="text-sm text-zinc-500 uppercase tracking-widest">Events Shot</div>
          </div>
          <div>
            <div className="text-4xl font-bold text-white mb-2">15+</div>
            <div className="text-sm text-zinc-500 uppercase tracking-widest">Cities Covered</div>
          </div>
          <div>
            <div className="text-4xl font-bold text-white mb-2">4.9/5</div>
            <div className="text-sm text-zinc-500 uppercase tracking-widest">User Rating</div>
          </div>
        </div>
      </section>

      {/* Final CTA */}
      <section className="py-32 relative overflow-hidden">
        <div className="absolute top-1/2 left-1/2 -translate-x-1/2 -translate-y-1/2 w-[600px] h-[600px] bg-white/5 blur-[120px] rounded-full -z-10" />
        <div className="max-w-4xl mx-auto px-6 text-center">
          <h2 className="text-4xl md:text-6xl font-bold text-white mb-8">Ready to capture your next big event?</h2>
          <p className="text-zinc-400 text-lg mb-12">
            Join thousands of satisfied customers who trust LensAI for their most precious moments.
            Get started today and experience the future of media production.
          </p>
          <div className="flex flex-col md:flex-row items-center justify-center gap-6">
            <button className="premium-button text-xl px-12 py-4">Get Started Now</button>
            <button className="secondary-button text-xl px-12 py-4">View Portfolio</button>
          </div>
        </div>
      </section>
    </div>
  );
}
