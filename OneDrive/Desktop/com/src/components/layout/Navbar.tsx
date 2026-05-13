"use client";

import React, { useState, useEffect } from "react";
import Link from "next/link";
import { Camera, Menu, X } from "lucide-react";
import { SignInButton, UserButton, useAuth } from "@clerk/nextjs";

const Navbar = () => {
  const { userId, isLoaded } = useAuth();
  const [isScrolled, setIsScrolled] = useState(false);
  const [isMobileMenuOpen, setIsMobileMenuOpen] = useState(false);

  useEffect(() => {
    const handleScroll = () => {
      setIsScrolled(window.scrollY > 20);
    };
    window.addEventListener("scroll", handleScroll);
    return () => window.removeEventListener("scroll", handleScroll);
  }, []);

  return (
    <nav
      className={`fixed top-0 left-0 right-0 z-50 transition-all duration-300 ${
        isScrolled ? "glass py-3" : "bg-transparent py-6"
      }`}
    >
      <div className="max-w-7xl mx-auto px-6 flex justify-between items-center">
        <Link href="/" className="flex items-center gap-2">
          <Camera className="w-8 h-8 text-white" />
          <span className="text-2xl font-bold tracking-tighter text-white">LensAI</span>
        </Link>

        {/* Desktop Nav */}
        <div className="hidden md:flex items-center gap-8 text-sm font-medium text-zinc-400">
          <Link href="#services" className="hover:text-white transition-colors">Services</Link>
          <Link href="#photographers" className="hover:text-white transition-colors">Photographers</Link>
          <Link href="#ai-editing" className="hover:text-white transition-colors">AI Editing</Link>
          <div className="flex items-center gap-4 ml-4">
            {isLoaded && !userId && (
              <SignInButton mode="modal">
                <button className="secondary-button text-xs py-2 px-6">Sign In</button>
              </SignInButton>
            )}
            {isLoaded && userId && (
              <UserButton />
            )}
          </div>
        </div>

        {/* Mobile Toggle */}
        <button 
          className="md:hidden text-white"
          onClick={() => setIsMobileMenuOpen(!isMobileMenuOpen)}
        >
          {isMobileMenuOpen ? <X /> : <Menu />}
        </button>
      </div>

      {/* Mobile Menu */}
      {isMobileMenuOpen && (
        <div className="md:hidden glass absolute top-full left-0 right-0 p-6 flex flex-col gap-6 animate-in slide-in-from-top duration-300">
          <Link href="#services" onClick={() => setIsMobileMenuOpen(false)}>Services</Link>
          <Link href="#photographers" onClick={() => setIsMobileMenuOpen(false)}>Photographers</Link>
          <Link href="#ai-editing" onClick={() => setIsMobileMenuOpen(false)}>AI Editing</Link>
          {isLoaded && !userId && (
            <SignInButton mode="modal">
              <button className="premium-button w-full">Sign In</button>
            </SignInButton>
          )}
        </div>
      )}
    </nav>
  );
};

export default Navbar;
